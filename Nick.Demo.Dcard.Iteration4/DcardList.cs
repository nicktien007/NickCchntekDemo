namespace Nick.Demo.Dcard.Iteration4
{
    //定義DcardList類別，用來表示Dcard的列表
    public class DcardList
    {
        public int id { get; set; }
        
        /// <summary>
        /// 標題
        /// </summary>
        public string title { get; set; }
        
        /// <summary>
        /// 內文摘要
        /// </summary>
        public string excerpt { get; set; }
    }
}