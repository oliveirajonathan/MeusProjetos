namespace ToDoList.Domain.Entidades
{
    public class Tarefa
    {
        public Tarefa(string descricao, bool conluido)
        {
            Descricao = descricao;
            Conluido = conluido;
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Conluido { get; set; }
    }
}