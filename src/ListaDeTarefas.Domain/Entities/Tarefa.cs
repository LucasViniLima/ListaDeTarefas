﻿using ListaDeTarefas.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace ListaDeTarefas.Domain.Entities
{

    [Table("Tarefas")]
    public class Tarefa : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get;  set; }
        public DateTimeOffset? CompletionDate { get; set; }
        public Priority Priority { get; set; }
    }
}