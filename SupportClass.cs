using System;
using System.Collections.Generic;
namespace HAM
{
    /// <summary>
    /// 单个题目的题目信息
    /// </summary>
    public class Question
    {
        /// <summary>
        /// 题库中第一项信息，未知用途
        /// </summary>
        public string J { get; set; }
        /// <summary>
        /// 题库中第二项信息，未知用途
        /// </summary>
        public string P { get; set; }
        /// <summary>
        /// 题库中第三项信息，未知用途
        /// </summary>
        public string I { get; set; }
        /// <summary>
        /// 题目的问题描述
        /// </summary>
        public string Q { get; set; }
        /// <summary>
        /// 题目的正确答案，由ABCD是否被选中转为10进制
        /// </summary>
        public string T { get; set; }
        /// <summary>
        /// 题目的A选项
        /// </summary>
        public string A { get; set; }
        /// <summary>
        /// 题目的B选项
        /// </summary>
        public string B { get; set; }
        /// <summary>
        /// 题目的C选项
        /// </summary>
        public string C { get; set; }
        /// <summary>
        /// 题目的D选项
        /// </summary>
        public string D { get; set; }
        /// <summary>
        /// 题目是否有配图
        /// </summary>
        public bool M { get; set; }
    }

    /// <summary>
    /// 单个题目的选项打乱信息与答题信息
    /// </summary>
    public class AnswerQuestion
    {
        // 从0开始
        public int QuestionId { get; set; }

        // 以打乱后的为准
        public bool? ASelected { get; set; }
        public bool? BSelected { get; set; }
        public bool? CSelected { get; set; }
        public bool? DSelected { get; set; }
        // 打乱后的正确答案
        public bool AMixed { get; set; }
        public bool BMixed { get; set; }
        public bool CMixed { get; set; }
        public bool DMixed { get; set; }
        //public bool this[int index]
        //{
        //    get
        //    {
        //        if(index == 0)
        //            return AMixed;
        //        else if(index == 1)
        //            return BMixed;
        //        else if(index == 2)
        //            return CMixed;
        //        else
        //            return DMixed;
        //    }
        //    set { }
        //}
        public bool? IfRight { get; set; }
        public int MixedAnsuer { get; set; }
        //含8421四个元素的数组，初始化时应被随机化
        public int[] SelectedArrange { get; set; }
    }

    /// <summary>
    /// 用户数据
    /// </summary>
    public class UserData
    {
        //public int NowBankAndMode { get; set; }
        public List<Question> NowBank { get; set; }

        /// <summary>
        /// 最后一次练习某题库的当前关注题
        /// </summary>
        public int NowAPIndex { get; set; }
        public int NowBPIndex { get; set; }
        public int NowCPIndex { get; set; }
        public int NowDPIndex { get; set; }

        /// <summary>
        /// 最后一次某题库考试的当前关注题
        /// </summary>
        public int NowAEIndex { get; set; }
        public int NowBEIndex { get; set; }
        public int NowCEIndex { get; set; }

        public int NowCount { get; set; }
        public int NowIndex { get; set; }

        /// <summary>
        /// 最后一次四种练习三种考试的答题信息，大小固定
        /// </summary>
        public AnswerQuestion[] APInfo { get; set; }
        public AnswerQuestion[] BPInfo { get; set; }
        public AnswerQuestion[] CPInfo { get; set; }
        public AnswerQuestion[] DPInfo { get; set; }
        public AnswerQuestion[] AEInfo { get; set; }
        public AnswerQuestion[] BEInfo { get; set; }
        public AnswerQuestion[] CEInfo { get; set; }

        /// <summary>
        /// 当前使用的题库与功能
        /// </summary>
        public AnswerQuestion[] NowInfo { get; set; }


        /// <summary>
        /// 最后一次模拟考试某类题库剩余时间
        /// </summary>
        //public DateTime ATime { get; set; }
        //public DateTime BTime { get; set; }
        //public DateTime CTime { get; set; }


        //public UserData()
        //{
        //    //用json导入信息
        //}
    }

}
