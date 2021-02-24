namespace ToDoList.Domain.Entidades
{
    public class Tarefa
    {
        public Tarefa(string descricao, bool concluido)
        {
            Descricao = descricao;
            Concluido = concluido;
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluido { get; set; }
    }
}