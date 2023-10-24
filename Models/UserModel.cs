using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwallowApplicationApi.Models
{

    [Table("t_user")]
    public class UserModel
    {
        [Key][Column("user_id")] public int UserId { get; set; }

        [Column("first_name")] public string? FirstName { get; set; }

        [Column("last_name")] public string? LastName { get; set; }
        [Column("nick_name")] public string? NickName { get; set; }
        [Column("sex")] public int Sex { get; set; }
    }
}
