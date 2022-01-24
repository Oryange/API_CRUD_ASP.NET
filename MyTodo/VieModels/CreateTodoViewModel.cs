using System.ComponentModel.DataAnnotations;
namespace MyTodo.VieModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public string Title { get; set; }
    }
}
