namespace CleanArchitecture.DataTransferObject.Dto
{
    public class RoleDto
    {
        public int Id { get; set; }
        public required string RoleName { get; set; }
        public required string RoleDescription { get; set; }
    }
}
