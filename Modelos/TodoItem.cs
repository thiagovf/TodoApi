namespace TodoApi.Modelos 
{
    public class TodoItem 
    {
        public long Id { get; set; }
        
        public string Nome { get; set; }
        
        public bool EstaCompleto { get; set; }

        public string Secret { get; set; }
    }
}