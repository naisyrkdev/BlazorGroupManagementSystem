namespace BlazorGroupManagementSystem.Models;

public class UserClientModel
{
    public string FirstName { get; init; } = String.Empty;
    public string LastName { get; init; } = String.Empty;
    public string ImgPath { get; init; } = String.Empty;
    public GroupEnum Group { get; set; }
    public string City { get; set; } = String.Empty;
}

public enum GroupEnum
{
    NoGroup,
    Group1,
    Group2,
    Group3,
    Group4,
    Group5
}