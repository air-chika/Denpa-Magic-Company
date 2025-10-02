namespace PayRoll_Client.ViewModel
{
    public interface ICRUDable
    {
        public string Title { get; }
        public int GetPageLength();
        public List<string> GetPageInfo(int pnum);
        public void CreateStart();
        public void UpdateStart(int pnum, int i);
        public void Delete(int pnum, int i);
        public void Back();
    }
}
