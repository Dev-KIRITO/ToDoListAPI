using System.Globalization;

namespace ToDoList.Models.Entities
{
    public class Comentario
    {
        public Guid Id { get; set; }
        public string Conteudo { get; set; } = string.Empty;
        public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
        public Guid TarefaId { get; set; }
        public Tarefa? Tarefa { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
