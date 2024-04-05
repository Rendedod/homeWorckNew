using homeWorck.folderWhithHomeWorck;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace homeWorck
{
    public partial class homeworck : Form
    {
        private bool isMenuMinimized;
        private byte WorkGroupNumber;
        private byte screenNumber;
        private int menuWhith;
        private bool[] isColapset;
        private Button[] buttonArray;
        private Panel[] panelArray;
        private Control[] allScreen;

        private Control screen1 = new Screen1();
        private Control screen2 = new Screen1();
        private Control screen3 = new Screen3();
        private Control screen4 = new Screen4();
        private Control screen5 = new Screen5();
        private Control screen6 = new Screen6();
        //№7
        private Control screen8 = new Screen8();
        private Control screen9 = new Screen9();
        private Control screen10 = new Screen10();
        private Control screen11 = new Screen11();
        //№12 - 17
        private Control screen18 = new Screen18();
        private Control screen19 = new Screen19();
        private Control screen20 = new Screen20();
        private Control screen21 = new Screen21();
        private Control screen22 = new Screen22();
        private Control screen23 = new Screen23();
        private Control screen24 = new Screen24();
        private Control screen25 = new Screen25();
        private Control screen26 = new Screen26();
        private Control screen27 = new Screen27();
        private Control screen28 = new Screen28();
        private Control screen29 = new Screen29();
        private Control screen30 = new Screen30();
        //№31
        private Control screen32 = new Screen32();
        private Control screen33 = new Screen33();
        private Control screen34 = new Screen34();
        private Control screen35 = new Screen35();
        private Control screen36 = new Screen36();
        private Control screen37 = new Screen37();
        private Control screen38 = new Screen38();
        //№39 - 40
        private Control screen41 = new Screen41();
        private Control screen42 = new Screen42();
        private Control screen43 = new Screen43();
        private Control screen44 = new Screen44();
        private Control screen45 = new Screen45();
        private Control screen46 = new Screen46();
        private Control screen47 = new Screen47();
        private Control screen48 = new Screen48();
        private Control screen49 = new Screen49();
        private Control screen50 = new Screen50();
        private Control screen51 = new Screen51();
        private Control screen52 = new Screen52();
        private Control screen53 = new Screen53();
        private Control screen54 = new Screen54();
        private Control screen55 = new Screen55();
        private Control screen56 = new Screen56();
        private Control screen57 = new Screen57();
        private Control screen58 = new Screen58();
        private Control screen59 = new Screen59();
        //№60
        private Control screen61 = new Screen61();
        private Control screen62 = new Screen62();
        private Control screen63 = new Screen63();
        //№64 - 65



        public homeworck()
        {
            InitializeComponent();
            KeyPreview = true;
            Load += homeWorck_Load;
            Resize += homeWorck_Resize;
            timerForWorckButton1.Tick += timerForWorckButton1_Tick;

        }

        private void homeWorck_Load(object sender, EventArgs e)
        {
            string path = @"C:\Ilya\forTest";
            Directory.CreateDirectory(path);

            buttonMenu.Width = 230;


            allScreen = new Control[] {  screen1,
                                         screen1,
                                         screen3,
                                         screen4,
                                         screen5,
                                         screen6,
                                         screen6,
                                         screen8,
                                         screen9,
                                         screen10,
                                         screen11,
                                         screen1,
                                         screen1,
                                         screen1,
                                         screen1,
                                         screen1,
                                         screen1,
                                         screen18,
                                         screen19,
                                         screen20,
                                         screen21,
                                         screen22,
                                         screen23,
                                         screen24,
                                         screen25,
                                         screen26,
                                         screen27,
                                         screen28,
                                         screen29,
                                         screen30,
                                         screen30,
                                         screen32,
                                         screen33,
                                         screen34,
                                         screen35,
                                         screen36,
                                         screen37,
                                         screen38,
                                         screen1,
                                         screen1,
                                         screen41,
                                         screen42,
                                         screen43,
                                         screen44,
                                         screen45,
                                         screen46,
                                         screen47,
                                         screen48,
                                         screen49,
                                         screen50,
                                         screen51,
                                         screen52,
                                         screen53,
                                         screen54,
                                         screen55,
                                         screen56,
                                         screen57,
                                         screen58,
                                         screen59,
                                         screen1,
                                         screen61,
                                         screen62,
                                         screen63,
            };

            buttonArray = new Button[] { buttonWorkGroup1,
                                         buttonWorkGroup2,
                                         buttonWorkGroup3,
                                         buttonWorkGroup4,
                                         buttonWorkGroup5,
                                         buttonWorkGroup6,
                                         buttonWorkGroup7,

            };

            panelArray = new Panel[] { panelForWorckButton1,
                                       panelForWorckButton2,
                                       panelForWorckButton3,
                                       panelForWorckButton4,
                                       panelForWorckButton5,
                                       panelForWorckButton6,
                                       panelForWorckButton7,

            };

            isColapset = new bool[panelArray.Length];
        }

        private void homeWorck_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F11)
            {
                if (WindowState != FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Maximized;
                }
                else if (FormBorderStyle == FormBorderStyle.Sizable)
                {
                    FormBorderStyle = FormBorderStyle.None;
                    buttonMenu.Margin = new Padding(5, 10, 0, 0);
                }
                else
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    buttonMenu.Margin = new Padding(0);
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            isMenuMinimized = !isMenuMinimized;
            if (isMenuMinimized)
            {
                Exit.Size = new Size(230, 50);
                Exit2.Size = new Size(230, 0);
                menu.Width = 25;
                foreach (Panel margnForPanel in panelArray)
                {
                    margnForPanel.Margin = new Padding(30, 0, 0, 0);
                }
            }
            else
            {
                Exit.Size = new Size(230, 0);
                Exit2.Size = new Size(230, 50);
                foreach (Panel margnForPanel in panelArray)
                {
                    margnForPanel.Margin = new Padding(0);
                }
                homeWorck_Resize(sender, e);
            }
        }

        private void homeWorck_Resize(object sender, EventArgs e)
        {
            if (!isMenuMinimized)
            {
                if (Width > 1150)
                {
                    menuWhith = 230;
                    menu.Width = menuWhith;
                    buttonMenu.Width = menuWhith;
                }
                else
                {
                    buttonMenu.Width = 230;
                    menu.Width = 230;
                }
            }
        }

        private void buttonWorkGroup_Click(object sender, EventArgs e)
        {
            if (!timerForWorckButton1.Enabled)
            {
                Button button = sender as Button;
                WorkGroupNumber = byte.Parse(button.Name.Substring(15));
                WorkGroupNumber -= 1;
                if (isColapset[WorkGroupNumber])
                {
                    buttonArray[WorkGroupNumber].Image = Properties.Resources.arrow_bottom;
                }
                else
                {
                    buttonArray[WorkGroupNumber].Image = Properties.Resources.arrow_up;
                }
                timerForWorckButton1.Start();
            }
        }

        private void timerForWorckButton1_Tick(object sender, EventArgs e)
        {
            if (isColapset[WorkGroupNumber])
            {
                panelArray[WorkGroupNumber].Height -= 10;
                if (panelArray[WorkGroupNumber].Size == panelArray[WorkGroupNumber].MinimumSize)
                {
                    timerForWorckButton1.Stop();
                    isColapset[WorkGroupNumber] = false;
                }
            }
            else
            {
                panelArray[WorkGroupNumber].Height += 10;
                if (panelArray[WorkGroupNumber].Size == panelArray[WorkGroupNumber].MaximumSize)
                {
                    timerForWorckButton1.Stop();
                    isColapset[WorkGroupNumber] = true;
                }
            }
        }

        private void worck_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            mainScreen.Controls.Clear();
            try
            {
                screenNumber = byte.Parse(button.Name.Substring(5));
                screenNumber--;
                mainScreen.Controls.Add(allScreen[screenNumber]);
            }
            catch (Exception ex)
            {
                mainScreen.Controls.Add(allScreen[0]);
            }

        }
        private void worck31_Click(object sender, EventArgs e)
        {
            showForm(new Screen31());
        }
        private void worck39_Click(object sender, EventArgs e)
        {
            new Screen39().Show();
        }
        private void worck40_Click(object sender, EventArgs e)
        {
            showForm(new Screen40());
        }
        private void worck60_Click(object sender, EventArgs e)
        {
            showForm(new Screen60());
        }
        private void worck64_Click(object sender, EventArgs e)
        {
            showForm(new Screen64());
        }
        private void worck65_Click(object sender, EventArgs e)
        {
            showForm(new Screen65());
        }

        private void showForm(Form screen)
        {
            screen.FormBorderStyle = FormBorderStyle.None;
            screen.WindowState = FormWindowState.Maximized;
            mainScreen.Controls.Clear();
            screen.TopLevel = false;
            mainScreen.Controls.Add(screen);
            screen.BringToFront();
            screen.Show();
        }

        private void showConsole_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = sender as Button;
                string fileNumber = button.Name.Substring(5);
                System.Diagnostics.Process.Start($@"C:\myCode\myC#Code\homeWorck\ConsoleScreen{fileNumber}\bin\Debug\ConsoleScreen{fileNumber}");
            }
            catch (Exception ex) 
            {
                System.Diagnostics.Process.Start($@"C:\myCode\myC#Code\homeWorck\ConsoleScreen12\bin\Debug\ConsoleScreen12");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
