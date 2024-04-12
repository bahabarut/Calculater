namespace HesapMakinesiMVC.Entities
{
    public class Process
    {
        public int ProcessId { get; set; }
        public string Number1 { get; set; }
        public string Number2 { get; set; }
        public string Result { get; set; }
        public string ProcessType { get; set; } 
        public DateTime CreatedDate { get; set; }
    }
}
