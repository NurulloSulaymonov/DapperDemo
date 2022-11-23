using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ContactController
{
    private ContactService _contactService;
    public ContactController()
    {
        _contactService = new ContactService();
    }

    [HttpGet("GetContacts")]
    public List<ContactDto> GetContacts()
    {
        return _contactService.GetContacts();
    }

    [HttpGet("GetInfo")]
    public string GetInfo()
    {
        return _contactService.GetInfo();
    }

    [HttpGet("AddNumbers")]
    public int AddNumbers(int a, int b)
    {
        return _contactService.AddNumbers(a, b);
    }

    [HttpGet("SubtractNumbers")]
    public int SubtractNumbers(int a, int b)
    {
        return _contactService.SubtractNumbers(a, b);
    }

    [HttpGet("MultiplyNumbers")]
    public int MultiplyNumbers(int a, int b)
    {
        return _contactService.MultiplyNumbers(a, b);
    }

    [HttpGet("DivideNumbers")]
    public int DivideNumbers(int a, int b)
    {
        return _contactService.DivideNumbers(a, b);
    }

    [HttpGet("SelectEnum")]
    public string SelectEnum(DayOfWeek week)
    {
        return week.ToString();
    }
}