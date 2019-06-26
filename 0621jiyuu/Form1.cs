using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0621jiyuu
{
    public partial class Form1 : Form
    {
        const int ITEM_COUNT = 10;//取るやつの数
        const int ENEMY_COUNT = 5;//敵の数
        const int TOTAL_COUNT = ITEM_COUNT + ENEMY_COUNT;//合計の数
        Label[] labels = new Label[TOTAL_COUNT];
        int[] vx = new int[TOTAL_COUNT];
        int[] vy = new int[TOTAL_COUNT];
        int left;//取るやつの残り数
        int ti;//経過時間

        private static Random ra = new Random();

        enum SCENE
        {
            TITLE,
            GAME,
            CLEAR,
            GAMEOVER,
            NONE
        }

        SCENE nowScene;
        SCENE nextScene;

        public Form1()
        {
            InitializeComponent();
            nextScene = SCENE.TITLE;//起動時に呼び出す
            nowScene = SCENE.NONE;

            //取るやつ、敵の設定
            for (int i = 0; i < TOTAL_COUNT; i++)
            {
                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Visible = false;
                labels[i].Font = new Font(labels[i].Font.OriginalFontName, 20);
                Controls.Add(labels[i]);
                if (i < ITEM_COUNT)//取るやつの設定
                {
                    labels[i].Text = "★";
                    labels[i].ForeColor = Color.Orange;
                }
                else//敵の設定
                {
                    labels[i].Text = "×";
                    labels[i].ForeColor = Color.Black;
                }
            }
        }

        void initScene()//初期化
        {
            if (nextScene == SCENE.NONE)
            {
                return;
            }

            nowScene = nextScene;
            nextScene = SCENE.NONE;//この処理が便利らしい

            switch (nowScene)
            {
                case SCENE.TITLE://タイトルの初期化
                    titleLabel.Visible = true;
                    startButton.Visible = true;
                    timeLabel.Visible = false;
                    leftLabel.Visible = false;
                    clearLabel.Visible = false;
                    modoruButton.Visible = false;
                    gmovLabel.Visible = false;
                    ti = 0;
                    for (int i = 0; i < TOTAL_COUNT; i++)
                    {
                        labels[i].Visible = false;
                    }
                    break;
                case SCENE.GAME://ゲーム画面の初期化
                    titleLabel.Visible = false;
                    startButton.Visible = false;
                    timeLabel.Visible = true;
                    leftLabel.Visible = true;
                    clearLabel.Visible = false;
                    modoruButton.Visible = false;
                    gmovLabel.Visible = false;
                    for (int i = 0; i < TOTAL_COUNT;i++ )
                    {
                        labels[i].Left = ra.Next(0, ClientSize.Width - labels[i].Width);
                        labels[i].Top = ra.Next(0, ClientSize.Height - labels[i].Height);
                        vx[i] = ra.Next(-5, 6);
                        vy[i] = ra.Next(-5, 6);
                        labels[i].Visible = true;
                    }
                    left = ITEM_COUNT;
                    leftLabel.Text = "残り:" + left + "個";
                    break;
                case SCENE.CLEAR://クリア画面
                    titleLabel.Visible = false;
                    startButton.Visible = false;
                    timeLabel.Visible = true;
                    leftLabel.Visible = true;
                    clearLabel.Visible = true;
                    modoruButton.Visible = true;
                    gmovLabel.Visible = false;
                    break;
                case SCENE.GAMEOVER://ゲームオーバー画面
                    titleLabel.Visible = false;
                    startButton.Visible = false;
                    timeLabel.Visible = true;
                    leftLabel.Visible = true;
                    clearLabel.Visible = false;
                    modoruButton.Visible = true;
                    gmovLabel.Visible = true;
                    break;
            }
        }

        void updateScene()
        {
            if (nowScene!=SCENE.GAME)//ゲーム画面での動き
            {
                return;
            }

            ti++;
            timeLabel.Text = "Time:" + ti;//経過時間

            for (int i = 0; i < TOTAL_COUNT; i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];//取るやつ、敵が動く
                if (labels[i].Left<0)//以下、画面端の跳ね返り処理
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (labels[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (labels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (labels[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
                Point mp = PointToClient(MousePosition);
                if (labels[i].Left < mp.X &&
                    labels[i].Right > mp.X &&
                    labels[i].Top < mp.Y &&
                    labels[i].Bottom > mp.Y)//マウスが重なったら
                {
                    if (i < ITEM_COUNT)//取るやつをとる
                    {
                        if (labels[i].Visible == true)
                        {
                            left--;
                        }
                        labels[i].Visible = false;
                        leftLabel.Text = "残り:" + left + "個";
                        if (left == 0)//全部取るとクリア
                        {
                            nextScene = SCENE.CLEAR;
                        }
                    }
                    else//敵に当たるとゲームオーバー
                    {
                        nextScene = SCENE.GAMEOVER;
                    }
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            nextScene = SCENE.GAME;//ボタンを押すとゲーム開始
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            initScene();
            updateScene();
        }

        private void modoruButton_Click(object sender, EventArgs e)
        {
            nextScene = SCENE.TITLE;//ボタンを押すとタイトルに戻る
        }
    }
}