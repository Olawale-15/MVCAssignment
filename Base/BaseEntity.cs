using System.ComponentModel.DataAnnotations;

namespace MVCAssignment.Base
{
	public class BaseEntity
	{
		[Key]
        public int Id { get; set; }
    }
}
