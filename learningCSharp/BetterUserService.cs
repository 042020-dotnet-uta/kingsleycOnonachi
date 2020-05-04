using System;

namespace learning
{
    public class UserService  
    {  
        EmailService _emailService;  
        DbContext _dbContext;

    public UserService(EmailService aEmailService, DbContext aDbContext)  
    {  
        _emailService = aEmailService;  
        _dbContext = aDbContext;  
    } 
     
    public void Register(string email, string password)  
    {  
        if (!_emailService.ValidateEmail(email))  
            throw new ValidationException("Email is not an email");  
            var user = new User(email, password);  
            _dbContext.Save(user);  
            emailService.SendEmail(new MailMessage("myname@mydomain.com", email) {Subject="Hi. How are you!"});  
    
        }  
   }  
}