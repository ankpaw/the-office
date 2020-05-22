namespace Angular9Assignment.Models
{
    public class Tier2Model
    {
        public string Title { get; set; }
        public string ParentTier1 { get; set; }
        public string OverviewText { get; set; }
        public ProgramCards[] ProgramCards { get; set; }
        public DataTableModel DataTable { get; set; }
        public KeyResourceModel[] KeyResources { get; set; }
    }
}
