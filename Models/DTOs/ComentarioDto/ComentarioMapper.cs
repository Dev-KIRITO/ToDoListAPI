using ToDoList.Models.Entities;


namespace ToDoList.Models.DTOs.ComentarioDto
{
    public static class ComentarioMapper
    {

        public static ComentarioResponseDto ToResponse(this Comentario c)
        {
            return new ComentarioResponseDto
            {
                Id = c.Id,
                Conteudo = c.Conteudo, // Corrigido de Texto para Conteudo  
                CriadoEm = c.CriadoEm,
                TarefaId = c.TarefaId,
                UsuarioId = c.UsuarioId,
                //NomeUsuario = c.Usuario.Nome // Usuario precisa estar carregado!
            };
        }

        public static Comentario ToEntity(this ComentarioCreateDto dto, Guid tarefaId, Guid usuarioId)
        {
            return new Comentario
            {
                Id = Guid.NewGuid(),
                Conteudo = dto.Conteudo, // Corrigido de Texto para Conteudo
                TarefaId = tarefaId,
                UsuarioId = usuarioId
            };
        }


    }
}