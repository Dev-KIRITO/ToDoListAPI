namespace ToDoList.Models.Entities
{
    public class Tarefa
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; } = string.Empty;
        public bool Concluida { get; set; } = false;
        // DateTime.UtcNow: Pega o horário exato que foi enviado
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public DateTime? Atuzlizada { get; set; } = DateTime.UtcNow;
        public DateTime? AtualizadadeEm { get; set; } = DateTime.UtcNow;
        // Relação com o Usuário 1 para N
        // A tareda pwerwbcw a um usuário
        public Guid UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

    }
}
