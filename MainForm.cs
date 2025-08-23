using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
namespace HAM
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 从json中提取的题库
        /// </summary>
        public List<Question> ABank = [];
        public List<Question> BBank = [];
        public List<Question> CBank = [];
        public List<Question> DBank;

        /// <summary>
        /// 题目列表按钮
        /// </summary>
        public List<Button> buttons = [];

        /// <summary>
        /// 四类题库的题目数量
        /// </summary>
        public static readonly int ABankSum = 683;
        public static readonly int BBankSum = 1143;
        public static readonly int CBankSum = 1282;
        public static readonly int DBankSum = 1375;
        /// <summary>
        /// 三类考试的考题数量
        /// </summary>
        public static readonly int AExamSum = 40;
        public static readonly int BExamSum = 60;
        public static readonly int CExamSum = 90;
        /// <summary>
        /// 三类考试的通过标准
        /// </summary>
        public static readonly int APassSum = 32;
        public static readonly int BPassSum = 45;
        public static readonly int CPassSum = 70;

        /// <summary>
        /// 用户信息
        /// </summary>
        public UserData UD;

        public static Random rand = new();

        public MainForm()
        {
            Init();
            //MessageBox.Show(ABank.Count.ToString() + " " + BBank.Count.ToString()+ " "+ CBank.Count.ToString() + " " + DBank.Count.ToString());
            InitializeComponent();
        }

        /// <summary>
        /// 导入题库和用户数据
        /// </summary>
        private void Init()
        {
            List<int> AInD;
            List<int> BInD;
            List<int> CInD;
            var options = new JsonSerializerOptions
            {
                WriteIndented = true, // 格式化
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping // 中文支持
            };

            // 读取四个题库
            // ABank = JsonSerializer.Deserialize<List<Question>>(Properties.Resources.A, options);
            // BBank = JsonSerializer.Deserialize<List<Question>>(Properties.Resources.B, options);
            // CBank = JsonSerializer.Deserialize<List<Question>>(Properties.Resources.C, options);
            DBank = JsonSerializer.Deserialize<List<Question>>(Properties.Resources.D, options);

            // 读取ABC三个题库在总题库中的题目索引
            AInD = JsonSerializer.Deserialize<List<int>>(Properties.Resources.AInD, options);
            BInD = JsonSerializer.Deserialize<List<int>>(Properties.Resources.BInD, options);
            CInD = JsonSerializer.Deserialize<List<int>>(Properties.Resources.CInD, options);

            ABank.AddRange(from int i in AInD select DBank[i]);
            BBank.AddRange(from int i in BInD select DBank[i]);
            CBank.AddRange(from int i in CInD select DBank[i]);
            try
            {
                // 用户数据储存在当前文件夹下的UserData.json中
                UD = JsonSerializer.Deserialize<UserData>(File.ReadAllText("UserData.json"), options);
            }
            catch(FileNotFoundException) // 如果用户文件不存在
            {
                File.WriteAllText("UserData.json", "", Encoding.UTF8);
                UD = new UserData();
            }
            catch(JsonException) // 如果用户文件为空
            {
                UD = new UserData();
            }
        }

        /// <summary>
        /// 打乱数组
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        private int[] MixArray(int[] nums)
        {
            for(int i = nums.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                (nums[i], nums[j]) = (nums[j], nums[i]); // 交换元素
            }
            return nums;
        }

        /// <summary>
        /// 生成答案
        /// </summary>
        /// <param name="NowBankAndMode"></param>
        private void GetMixedAnswer()
        {
            //题库答案：AD
            //SelectedArrange：[2, 3, 1, 0]
            //新答案：AC
            //遍历SelectedArrange
            for(int i = 0; i < UD.NowCount; i++)
            {
                // oriAns是题库的答案（未经打乱）
                (bool, bool, bool, bool) oriAns = (
                    UD.NowBank[UD.NowInfo[i].QuestionId].T.IndexOf("A") != -1, UD.NowBank[UD.NowInfo[i].QuestionId].T.IndexOf("B") != -1, UD.NowBank[UD.NowInfo[i].QuestionId].T.IndexOf("C") != -1, UD.NowBank[UD.NowInfo[i].QuestionId].T.IndexOf("D") != -1);

                // 用switch匹配全部24中选项打乱方法
                switch((UD.NowInfo[i].SelectedArrange[0], UD.NowInfo[i].SelectedArrange[1], UD.NowInfo[i].SelectedArrange[2], UD.NowInfo[i].SelectedArrange[3]))
                {
                    case (0, 1, 2, 3):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item1, oriAns.Item2, oriAns.Item3, oriAns.Item4);
                        break;
                    case (0, 1, 3, 2):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item1, oriAns.Item2, oriAns.Item4, oriAns.Item3);
                        break;
                    case (0, 2, 1, 3):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item1, oriAns.Item3, oriAns.Item2, oriAns.Item4);
                        break;
                    case (0, 2, 3, 1):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item1, oriAns.Item3, oriAns.Item4, oriAns.Item2);
                        break;
                    case (0, 3, 1, 2):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item1, oriAns.Item4, oriAns.Item2, oriAns.Item3);
                        break;
                    case (0, 3, 2, 1):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item1, oriAns.Item4, oriAns.Item3, oriAns.Item2);
                        break;
                    case (1, 0, 2, 3):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item2, oriAns.Item1, oriAns.Item3, oriAns.Item4);
                        break;
                    case (1, 0, 3, 2):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item2, oriAns.Item1, oriAns.Item4, oriAns.Item3);
                        break;
                    case (1, 2, 0, 3):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item2, oriAns.Item3, oriAns.Item1, oriAns.Item4);
                        break;
                    case (1, 2, 3, 0):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item2, oriAns.Item3, oriAns.Item4, oriAns.Item1);
                        break;
                    case (1, 3, 0, 2):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item2, oriAns.Item4, oriAns.Item1, oriAns.Item3);
                        break;
                    case (1, 3, 2, 0):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item2, oriAns.Item4, oriAns.Item3, oriAns.Item1);
                        break;
                    case (2, 0, 1, 3):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item3, oriAns.Item1, oriAns.Item2, oriAns.Item4);
                        break;
                    case (2, 0, 3, 1):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item3, oriAns.Item1, oriAns.Item4, oriAns.Item2);
                        break;
                    case (2, 1, 0, 3):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item3, oriAns.Item2, oriAns.Item1, oriAns.Item4);
                        break;
                    case (2, 1, 3, 0):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item3, oriAns.Item2, oriAns.Item4, oriAns.Item1);
                        break;
                    case (2, 3, 0, 1):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item3, oriAns.Item4, oriAns.Item1, oriAns.Item2);
                        break;
                    case (2, 3, 1, 0):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item3, oriAns.Item4, oriAns.Item2, oriAns.Item1);
                        break;
                    case (3, 0, 1, 2):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item4, oriAns.Item1, oriAns.Item2, oriAns.Item3);
                        break;
                    case (3, 0, 2, 1):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item4, oriAns.Item1, oriAns.Item3, oriAns.Item2);
                        break;
                    case (3, 1, 0, 2):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item4, oriAns.Item2, oriAns.Item1, oriAns.Item3);
                        break;
                    case (3, 1, 2, 0):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item4, oriAns.Item2, oriAns.Item3, oriAns.Item1);
                        break;
                    case (3, 2, 0, 1):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item4, oriAns.Item3, oriAns.Item1, oriAns.Item2);
                        break;
                    case (3, 2, 1, 0):
                        (UD.NowInfo[i].AMixed, UD.NowInfo[i].BMixed, UD.NowInfo[i].CMixed, UD.NowInfo[i].DMixed) = (oriAns.Item4, oriAns.Item3, oriAns.Item2, oriAns.Item1);
                        break;
                    default:
                        throw new Exception("选项未打乱而尝试确定新答案。");
                }
            }
        }

        /// <summary>
        /// 显示问题的题目、选项和图片
        /// </summary>
        private void ShowQuestion()
        {
            // 显示题目信息
            QueTextBox.Text = String.Format("{0}\t\t{1}\t\t{2}\t\t第{3}题\n{4}",
                UD.NowBank[UD.NowInfo[UD.NowIndex].QuestionId].J,
                UD.NowBank[UD.NowInfo[UD.NowIndex].QuestionId].P,
                UD.NowBank[UD.NowInfo[UD.NowIndex].QuestionId].I,
                UD.NowIndex + 1,
                UD.NowBank[UD.NowInfo[UD.NowIndex].QuestionId].Q);

            // 获取当前题目的选项打乱顺序
            int[] arrange = UD.NowInfo[UD.NowIndex].SelectedArrange;
            // 获取当前题目的选项数据
            Question currentQuestion = UD.NowBank[UD.NowInfo[UD.NowIndex].QuestionId];
            // 存储原始选项的数组（0:A, 1:B, 2:C, 3:D）
            string[] originalOptions = new string[]
            {
                currentQuestion.A,
                currentQuestion.B,
                currentQuestion.C,
                currentQuestion.D
            };

            // 根据打乱顺序设置每个选项文本框的内容
            ChoATextBox.Text = $" A：{originalOptions[arrange[0]]}";
            ChoBTextBox.Text = $" B：{originalOptions[arrange[1]]}";
            ChoCTextBox.Text = $" C：{originalOptions[arrange[2]]}";
            ChoDTextBox.Text = $" D：{originalOptions[arrange[3]]}";

            // 显示图片
            if(UD.NowBank[UD.NowInfo[UD.NowIndex].QuestionId].M)
            {
                QuePicBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(UD.NowBank[UD.NowInfo[UD.NowIndex].QuestionId].J);
                QuePicBox.SizeMode = PictureBoxSizeMode.Zoom; // 按比例缩放适应控件
                // 其他模式：Normal（默认）、StretchImage（拉伸填充）、AutoSize（控件适应图片大小）等
            }
            else
            {
                QuePicBox.Image = null;
            }
        }

        /// <summary>
        /// 设置选项的颜色
        /// </summary>
        private void ChoColor()
        {
            // 练习模式中尚未点击确定按钮或在模拟考试中的情况
            // 如果选项被选中就变灰Color.DarkGray，否则为白色Color.White
            if(UD.NowInfo[UD.NowIndex].IfRight == null)
            {
                ChoATextBox.BackColor = UD.NowInfo[UD.NowIndex].ASelected == true ? Color.DarkGray : Color.White;
                ChoBTextBox.BackColor = UD.NowInfo[UD.NowIndex].BSelected == true ? Color.DarkGray : Color.White;
                ChoCTextBox.BackColor = UD.NowInfo[UD.NowIndex].CSelected == true ? Color.DarkGray : Color.White;
                ChoDTextBox.BackColor = UD.NowInfo[UD.NowIndex].DSelected == true ? Color.DarkGray : Color.White;
            }
            // 练习模式下点击确定按钮后显示正确选项与错误选项
            else
            {
                // 正确选项显示浅绿色Color.LightGreen
                if(UD.NowInfo[UD.NowIndex].AMixed == true)
                {
                    ChoATextBox.BackColor = Color.LightGreen;
                }
                // 被选中的错误选项显示浅红色Color.PaleVioletRed
                else if(UD.NowInfo[UD.NowIndex].ASelected == true)
                {
                    ChoATextBox.BackColor = Color.PaleVioletRed;
                }
                // 没有被选中的错误选项为白色
                else
                {
                    ChoATextBox.BackColor = Color.White;
                }

                if(UD.NowInfo[UD.NowIndex].BMixed == true)
                {
                    ChoBTextBox.BackColor = Color.LightGreen;
                }
                else if(UD.NowInfo[UD.NowIndex].BSelected == true)
                {
                    ChoBTextBox.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    ChoBTextBox.BackColor = Color.White;
                }

                if(UD.NowInfo[UD.NowIndex].CMixed == true)
                {
                    ChoCTextBox.BackColor = Color.LightGreen;
                }
                else if(UD.NowInfo[UD.NowIndex].CSelected == true)
                {
                    ChoCTextBox.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    ChoCTextBox.BackColor = Color.White;
                }

                if(UD.NowInfo[UD.NowIndex].DMixed == true)
                {
                    ChoDTextBox.BackColor = Color.LightGreen;
                }
                else if(UD.NowInfo[UD.NowIndex].DSelected == true)
                {
                    ChoDTextBox.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    ChoDTextBox.BackColor = Color.White;
                }
            }
        }

        /// <summary>
        /// 初始化题目列表按钮
        /// </summary>
        private void QueChoShow()
        {
            // 去除上次做题的干扰
            buttons.Clear();
            QueChoPanel.Controls.Clear();
            for(int i = 0; i < UD.NowCount; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(50, 50);
                btn.Text = (i + 1).ToString();
                btn.Font = new Font("等线", 15, FontStyle.Regular);
                btn.Click += QueChoJump; // 为按钮绑定点击事件，提供直接选择题目功能（跳转功能）
                // 设置按钮颜色
                buttons.Add(btn);
                QueChoColor(i); // 设置按钮的颜色
                QueChoPanel.Controls.Add(btn); // 使按钮在界面中显现出来
            }

        }

        /// <summary>
        /// 题目列表按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueChoJump(object sender, EventArgs e)
        {
            int tempIndex = UD.NowIndex; // 为了正确显示跳转之后跳转前的当前按钮的颜色
            UD.NowIndex = int.Parse(((Button)sender).Text) - 1;
            ShowQuestion();
            ChoColor();
            QueChoColor(tempIndex);
            QueChoColor(UD.NowIndex);
        }

        /// <summary>
        /// 题目列表按钮颜色
        /// </summary>
        /// <param name="index"></param>
        private void QueChoColor(int index)
        {
            if(UD.NowInfo[index].IfRight == null)
            {
                // 题的选项完全没有被点击过
                if(UD.NowInfo[index].ASelected == null)
                {
                    buttons[index].BackColor = Color.White;
                }
                // 题的选项虽然被选中，但又撤销，相当于什么都没选
                else if(UD.NowInfo[index].ASelected == false && UD.NowInfo[index].BSelected == false && UD.NowInfo[index].CSelected == false && UD.NowInfo[index].DSelected == false)
                {
                    buttons[index].BackColor = Color.White;
                }
                // 剩下的就是题目已经被作答，但还没点击确定或是在模拟考试
                else
                {
                    buttons[index].BackColor = Color.Gray;
                }
            }
            // 练习模式下该题已经被点击确定按钮，正确情况和错误情况
            else if(UD.NowInfo[index].IfRight == true)
            {
                buttons[index].BackColor = Color.LightGreen;
            }
            else
            {
                buttons[index].BackColor = Color.PaleVioletRed;
            }
            // 把当前正在做（看）的题对应的按钮设置为浅蓝色Color.LightBlue
            if(UD.NowIndex == index)
            {
                buttons[UD.NowIndex].BackColor = Color.LightBlue;
            }
        }

        /// <summary>
        /// 保存当前进度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            File.WriteAllText("UserData.json", JsonSerializer.Serialize(UD, options));
        }

        /// <summary>
        /// ABCD的继续练习
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PContinue_Click(object sender, EventArgs e)
        {
            if(UD.NowInfo == null)
            {
                MessageBox.Show("没有上次练习记录，请点击新的练习。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 这四个函数的顺序不能颠倒，下同
            ShowQuestion();
            GetMixedAnswer();
            ChoColor();
            QueChoShow();
        }

        /// <summary>
        /// ABCD的正序练习
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PPositive_Click(object sender, EventArgs e)
        {
            //ABC和总题库的正序练习共用一个函数，先分辨由哪个按钮触发事件
            if(sender.Equals(APPositive))
            {
                UD.NowBank = ABank;
                UD.NowCount = ABankSum;
                UD.APInfo = new AnswerQuestion[UD.NowCount];
                UD.NowInfo = UD.APInfo;
                UD.NowAPIndex = 0; // 默认从第一道题开始
                UD.NowIndex = UD.NowAPIndex;

            }
            else if(sender.Equals(BPPositive))
            {
                UD.NowBank = BBank;
                UD.NowCount = BBankSum;
                UD.BPInfo = new AnswerQuestion[UD.NowCount];
                UD.NowInfo = UD.BPInfo;
                UD.NowBPIndex = 0;
                UD.NowIndex = UD.NowBPIndex;
            }
            else if(sender.Equals(CPPositive))
            {
                UD.NowBank = CBank;
                UD.NowCount = CBankSum;
                UD.CPInfo = new AnswerQuestion[UD.NowCount];
                UD.NowInfo = UD.CPInfo;
                UD.NowCPIndex = 0;
                UD.NowIndex = UD.NowCPIndex;
            }
            else if(sender.Equals(DPPositive))
            {
                UD.NowBank = DBank;
                UD.NowCount = DBankSum;
                UD.DPInfo = new AnswerQuestion[UD.NowCount];
                UD.NowInfo = UD.DPInfo;
                UD.NowDPIndex = 0;
                UD.NowIndex = UD.NowDPIndex;
            }
            else
            {
                throw new Exception("正序练习未被正确调用。");
            }

            //问题顺序确定与打乱选项数组生成
            for(int i = 0; i < UD.NowCount; i++)
            {
                UD.NowInfo[i] = new AnswerQuestion();
                UD.NowInfo[i].QuestionId = i; // 正序练习下直接分配即可
                UD.NowInfo[i].SelectedArrange = MixArray([0, 1, 2, 3]);
            }
            ShowQuestion();
            GetMixedAnswer();
            ChoColor();
            QueChoShow();
        }

        /// <summary>
        /// ABCD的随机练习
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PRandom_Click(object sender, EventArgs e)
        {
            if(sender.Equals(APRandom))
            {
                UD.NowBank = ABank;
                UD.NowCount = ABankSum;
                UD.APInfo = new AnswerQuestion[UD.NowCount];
                UD.NowInfo = UD.APInfo;
                UD.NowAPIndex = 0;
                UD.NowIndex = UD.NowAPIndex;

            }
            else if(sender.Equals(BPRandom))
            {
                UD.NowBank = BBank;
                UD.NowCount = BBankSum;
                UD.BPInfo = new AnswerQuestion[UD.NowCount];
                UD.NowInfo = UD.BPInfo;
                UD.NowBPIndex = 0;
                UD.NowIndex = UD.NowBPIndex;
            }
            else if(sender.Equals(CPRandom))
            {
                UD.NowBank = CBank;
                UD.NowCount = CBankSum;
                UD.CPInfo = new AnswerQuestion[UD.NowCount];
                UD.NowInfo = UD.CPInfo;
                UD.NowCPIndex = 0;
                UD.NowIndex = UD.NowCPIndex;
            }
            else if(sender.Equals(DPRandom))
            {
                UD.NowBank = DBank;
                UD.NowCount = DBankSum;
                UD.DPInfo = new AnswerQuestion[UD.NowCount];
                UD.NowInfo = UD.DPInfo;
                UD.NowDPIndex = 0;
                UD.NowIndex = UD.NowDPIndex;
            }
            else
            {
                throw new Exception("随机练习未被正确调用。");
            }

            //问题顺序与打乱选项数组生成
            int[] nums = [.. Enumerable.Range(0, UD.NowCount)]; // 生成从0到UD.NowCount - 1 的数组，即[0, 1, 2, ..., UD.NowCount - 1]
            MixArray(nums); // 打乱该数组实现随机出题
            for(int i = 0; i < UD.NowCount; i++)
            {
                UD.NowInfo[i] = new AnswerQuestion();
                UD.NowInfo[i].QuestionId = nums[i];
                UD.NowInfo[i].SelectedArrange = MixArray([0, 1, 2, 3]);
            }
            ShowQuestion();
            GetMixedAnswer();
            ChoColor();
            QueChoShow();
        }

        /// <summary>
        /// ABCD的乱序练习
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PNegaitve_Click(object sender, EventArgs e)
        {
            if(sender.Equals(APNegative))
            {
                UD.NowBank = ABank;
                UD.NowCount = ABankSum;
                UD.APInfo = new AnswerQuestion[UD.NowCount];
                UD.NowInfo = UD.APInfo;
                UD.NowAPIndex = 0;
                UD.NowIndex = UD.NowAPIndex;

            }
            else if(sender.Equals(BPNegative))
            {
                UD.NowBank = BBank;
                UD.NowCount = BBankSum;
                UD.BPInfo = new AnswerQuestion[UD.NowCount];
                UD.NowInfo = UD.BPInfo;
                UD.NowBPIndex = 0;
                UD.NowIndex = UD.NowBPIndex;
            }
            else if(sender.Equals(CPNegative))
            {
                UD.NowBank = CBank;
                UD.NowCount = CBankSum;
                UD.CPInfo = new AnswerQuestion[UD.NowCount];
                UD.NowInfo = UD.CPInfo;
                UD.NowCPIndex = 0;
                UD.NowIndex = UD.NowCPIndex;
            }
            else if(sender.Equals(DPNegative))
            {
                UD.NowBank = DBank;
                UD.NowCount = DBankSum;
                UD.DPInfo = new AnswerQuestion[UD.NowCount];
                UD.NowInfo = UD.DPInfo;
                UD.NowDPIndex = 0;
                UD.NowIndex = UD.NowDPIndex;
            }
            else
            {
                throw new Exception("乱序练习未被正确调用。");
            }

            //问题顺序与打乱选项数组生成
            for(int i = 0; i < UD.NowCount; i++)
            {
                UD.NowInfo[i] = new AnswerQuestion();
                UD.NowInfo[i].QuestionId = UD.NowCount - i - 1;
                UD.NowInfo[i].SelectedArrange = MixArray([0, 1, 2, 3]);
            }
            ShowQuestion();
            GetMixedAnswer();
            ChoColor();
            QueChoShow();
        }

        /// <summary>
        /// ABC继续考试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EContinue_Click(Object sender, EventArgs e)
        {
            if(UD.NowInfo == null)
            {
                MessageBox.Show("没有上次模拟考试记录，请点击新的考试。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ShowQuestion();
            GetMixedAnswer();
            ChoColor();
            QueChoShow();
        }

        /// <summary>
        /// ABC的新的考试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        private void ENew_Click(object sender, EventArgs e)
        {
            int[] nums;
            if(sender.Equals(AENew))
            {
                UD.NowBank = ABank;
                UD.NowCount = AExamSum;
                UD.AEInfo = new AnswerQuestion[UD.NowCount];
                UD.NowInfo = UD.AEInfo;
                UD.NowAPIndex = 0;
                UD.NowIndex = UD.NowAPIndex;
                nums = [.. Enumerable.Range(0, ABankSum)];

            }
            else if(sender.Equals(BENew))
            {
                UD.NowBank = BBank;
                UD.NowCount = BExamSum;
                UD.BEInfo = new AnswerQuestion[UD.NowCount];
                UD.NowInfo = UD.BEInfo;
                UD.NowBPIndex = 0;
                UD.NowIndex = UD.NowBPIndex;
                nums = [.. Enumerable.Range(0, BBankSum)];
            }
            else if(sender.Equals(CENew))
            {
                UD.NowBank = CBank;
                UD.NowCount = CExamSum;
                UD.CEInfo = new AnswerQuestion[UD.NowCount];
                UD.NowInfo = UD.CEInfo;
                UD.NowCPIndex = 0;
                UD.NowIndex = UD.NowCPIndex;
                nums = [.. Enumerable.Range(0, CBankSum)];
            }
            else
            {
                throw new Exception("新的考试未被正确调用。");
            }

            // 问题顺序与打乱选项数组生成
            // 因为考试是从题库中抽题，所以选题数组nums的范围为题库范围，定义放在了上面
            // nums = [.. Enumerable.Range(0, UD.NowCount)];
            MixArray(nums);
            for(int i = 0; i < UD.NowCount; i++)
            {
                UD.NowInfo[i] = new AnswerQuestion();
                UD.NowInfo[i].QuestionId = nums[i];
                UD.NowInfo[i].SelectedArrange = MixArray([0, 1, 2, 3]);
            }
            ShowQuestion();
            GetMixedAnswer();
            ChoColor();
            QueChoShow();
        }

        /// <summary>
        /// 选择选项的答案记录与变色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        private void ChoTextBox_Click(object sender, EventArgs e)
        {
            //这里修改颜色是因为这里颜色修改操作少，不用调用ChoColor()

            // 练习模式下如果题目已经被点击确定，看到了正确答案，就不能再更改答案，直接跳出
            if(UD.NowInfo[UD.NowIndex].IfRight != null)
            {
                return;
            }
            // 函数一旦进行到这里就说明题目的四个选项都已经进行了选与不选的选择，所以先全部置为false，这只会在四个Selected为null的前提下变为false
            UD.NowInfo[UD.NowIndex].ASelected ??= false;
            UD.NowInfo[UD.NowIndex].BSelected ??= false;
            UD.NowInfo[UD.NowIndex].CSelected ??= false;
            UD.NowInfo[UD.NowIndex].DSelected ??= false;

            if(sender.Equals(ChoATextBox))
            {
                // 如果选中，设为没选中；没选中则相反，因此要提前把可能的null设为false
                UD.NowInfo[UD.NowIndex].ASelected = !UD.NowInfo[UD.NowIndex].ASelected;
                // 对应改变选项的颜色
                ChoATextBox.BackColor = (bool)UD.NowInfo[UD.NowIndex].ASelected ? Color.DarkGray : Color.White;
            }
            else if(sender.Equals(ChoBTextBox))
            {
                UD.NowInfo[UD.NowIndex].BSelected = !UD.NowInfo[UD.NowIndex].BSelected;
                ChoBTextBox.BackColor = (bool)UD.NowInfo[UD.NowIndex].BSelected ? Color.DarkGray : Color.White;
            }
            else if(sender.Equals(ChoCTextBox))
            {
                UD.NowInfo[UD.NowIndex].CSelected = !UD.NowInfo[UD.NowIndex].CSelected;
                ChoCTextBox.BackColor = (bool)UD.NowInfo[UD.NowIndex].CSelected ? Color.DarkGray : Color.White;
            }
            else if(sender.Equals(ChoDTextBox))
            {
                UD.NowInfo[UD.NowIndex].DSelected = !UD.NowInfo[UD.NowIndex].DSelected;
                ChoDTextBox.BackColor = (bool)UD.NowInfo[UD.NowIndex].DSelected ? Color.DarkGray : Color.White;
            }
        }

        /// <summary>
        /// 上一题按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LastQueButton_Click(object sender, EventArgs e)
        {
            // 由于刚进入程序时没有加载题目列表按钮，所以通过检测题目列表是否有按钮来确定上一题/下一题/确定/提交按钮是否可用
            if(QueChoPanel.Controls.Count == 0)
            {
                MessageBox.Show("尚未选择题库和模式。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(UD.NowIndex > 0)
            {
                UD.NowIndex--;
                ShowQuestion();
                ChoColor();
                QueChoColor(UD.NowIndex + 1);
                QueChoColor(UD.NowIndex);
            }
            else
            {
                MessageBox.Show("这是第一道题。");
            }
        }

        /// <summary>
        /// 下一题按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextQuebutton_Click(object sender, EventArgs e)
        {
            if(QueChoPanel.Controls.Count == 0)
            {
                MessageBox.Show("尚未选择题库和模式。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(UD.NowIndex < UD.NowCount - 1)
            {
                UD.NowIndex++;
                ShowQuestion();
                ChoColor();
                QueChoColor(UD.NowIndex - 1);
                QueChoColor(UD.NowIndex);
            }
            else
            {
                MessageBox.Show("这是最后一道题。");
            }
        }

        /// <summary>
        /// 练习模式的确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckAnsButton_Click(object sender, EventArgs e)
        {
            if(QueChoPanel.Controls.Count == 0)
            {
                MessageBox.Show("尚未选择题库和模式。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(UD.NowInfo.Equals(UD.AEInfo) || UD.NowInfo.Equals(UD.BEInfo) || UD.NowInfo.Equals(UD.CEInfo) || UD.NowInfo[UD.NowIndex].IfRight != null)
            {
                MessageBox.Show("模拟考试中确定按钮不可用。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(UD.NowInfo[UD.NowIndex].ASelected == UD.NowInfo[UD.NowIndex].AMixed && UD.NowInfo[UD.NowIndex].BSelected == UD.NowInfo[UD.NowIndex].BMixed && UD.NowInfo[UD.NowIndex].CSelected == UD.NowInfo[UD.NowIndex].CMixed && UD.NowInfo[UD.NowIndex].DSelected == UD.NowInfo[UD.NowIndex].DMixed)
            {
                UD.NowInfo[UD.NowIndex].IfRight = true;
            }
            else
            {
                UD.NowInfo[UD.NowIndex].IfRight = false;
            }
            ChoColor();
            QueChoColor(UD.NowIndex);
        }

        /// <summary>
        /// 模拟考试的提交按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(QueChoPanel.Controls.Count == 0)
            {
                MessageBox.Show("尚未选择题库和模式。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(UD.NowInfo.Equals(UD.APInfo) || UD.NowInfo.Equals(UD.BPInfo) || UD.NowInfo.Equals(UD.CPInfo) || UD.NowInfo.Equals(UD.DPInfo))
            {
                MessageBox.Show("练习模式中提交按钮不可用。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(UD.NowInfo[UD.NowIndex].IfRight != null)
            {
                MessageBox.Show("模拟考试已结束。请点击“新的考试”或进行其它练习。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(MessageBox.Show("是否提交并查看模拟考试成绩？", "提交？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            int rightSum = 0;
            for(int i = 0; i < UD.NowCount; i++)
            {
                if(UD.NowInfo[i].ASelected == UD.NowInfo[i].AMixed && UD.NowInfo[i].BSelected == UD.NowInfo[i].BMixed && UD.NowInfo[i].CSelected == UD.NowInfo[i].CMixed && UD.NowInfo[i].DSelected == UD.NowInfo[i].DMixed)
                {
                    UD.NowInfo[i].IfRight = true;
                    rightSum++;
                }
                else
                {
                    UD.NowInfo[i].IfRight = false;
                }
            }
            if(UD.NowInfo.Equals(UD.AEInfo))
            {
                if(rightSum >= APassSum)
                {
                    MessageBox.Show("您答对了" + rightSum.ToString() + "道题，答错" + (AExamSum - rightSum).ToString() + "道题\n恭喜您通过A类模拟考试！", "模拟考试结果");
                }
                else
                {
                    MessageBox.Show("您答对了" + rightSum.ToString() + "道题，答错" + (AExamSum - rightSum).ToString() + "道题\n很遗憾，您未能通过模拟考试，下次努力！", "模拟考试结果");
                }
            }
            else if(UD.NowInfo.Equals(UD.BEInfo))
            {
                if(rightSum >= BPassSum)
                {
                    MessageBox.Show("您答对了" + rightSum.ToString() + "道题，答错" + (BExamSum - rightSum).ToString() + "道题\n恭喜您通过B类模拟考试！", "模拟考试结果");
                }
                else
                {
                    MessageBox.Show("您答对了" + rightSum.ToString() + "道题，答错" + (BExamSum - rightSum).ToString() + "道题\n很遗憾，您未能通过模拟考试，下次努力！", "模拟考试结果");
                }
            }
            else if(UD.NowInfo.Equals(UD.CEInfo))
            {
                if(rightSum >= CPassSum)
                {
                    MessageBox.Show("您答对了" + rightSum.ToString() + "道题，答错" + (CExamSum - rightSum).ToString() + "道题\n恭喜您通过B类模拟考试！", "模拟考试结果");
                }
                else
                {
                    MessageBox.Show("您答对了" + rightSum.ToString() + "道题，答错" + (CExamSum - rightSum).ToString() + "道题\n很遗憾，您未能通过模拟考试，下次努力！", "模拟考试结果");
                }
            }
            else
            {
                throw (new Exception("当前活跃项非模拟考试。"));
            }
            ChoColor();
            for(int i = 0; i < UD.NowCount; i++)
            {
                QueChoColor(i);
            }
        }

        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者：一只学生兔\n欢迎与本人联系！\n电话：13734178206\nQQ：2218624634", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 点击关闭按钮时调用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // 显示包含三个选项的消息框
            DialogResult result = MessageBox.Show(
                "退出前是否保存当前进度？",
                "退出？",
                MessageBoxButtons.YesNoCancel,  // 三个选项：Yes=保存并退出，No=不保存退出，Cancel=取消
                MessageBoxIcon.Warning
            );

            // 根据用户选择进行处理
            switch(result)
            {
                // 保存并退出
                case DialogResult.Yes:
                    // 保存操作
                    Save_Click(null, null);
                    // 允许关闭窗口
                    e.Cancel = false;
                    break;
                // 直接退出
                case DialogResult.No:
                    e.Cancel = false;
                    break;
                // 不退出
                case DialogResult.Cancel:
                    // 取消关闭
                    e.Cancel = true;
                    break;
            }
            base.OnFormClosing(e);
        }
    }
}
