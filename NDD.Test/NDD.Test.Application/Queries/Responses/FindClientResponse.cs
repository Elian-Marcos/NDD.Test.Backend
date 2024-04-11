﻿using MediatR;

namespace NDD.Test.Application.Queries.Responses
{
    public class FindClientResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Observation { get; set; }
    }
}
