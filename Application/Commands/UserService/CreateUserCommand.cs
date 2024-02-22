﻿using MediatR;

namespace Application.Commands.UserService
{
    public class CreateUserCommand : IRequest<int>
    {
        public int Id  { get; set; }
    
        
        public string Address { get; set; }
        
    
        
        public int Age { get; set; }
        
    
        
        public string Email { get; set; }
        
    
        
        public string Name { get; set; }
        
    
        
        public string Phone { get; set; }
        
    
    }
}
