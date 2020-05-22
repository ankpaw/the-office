namespace Angular9Assignment.Models
{
    public class ProgramCards
    {
        public string Title { get; set; }
        public string Descrioption { get; set; }
        public string Value { get; set; }
        public string Unit { get; set; }
    }

    public class DataTableModel
    { 
        public string[] Headers { get; set; }
        public string[][] Data { get; set; }
    }
}
