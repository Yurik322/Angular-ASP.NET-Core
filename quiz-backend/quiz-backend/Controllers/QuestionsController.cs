﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace quiz_backend.Controllers
{
    //[Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly QuizContext context;
        public QuestionsController(QuizContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Models.Question> Get()
        {
            return context.Questions;
        }

        [HttpPost]
        public void Post([FromBody] Models.Question question)
        {
            context.Questions.Add(question);
            context.SaveChanges();
        }

        [HttpPut("{id}")]
        public async void Put(int id, [FromBody] Models.Question questionData)
        {
            var question = await context.Questions.s
        }
    }
}
