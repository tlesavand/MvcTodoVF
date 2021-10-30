using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcTodo.Models;

    public class TodosContext : DbContext
    {
        public TodosContext (DbContextOptions<TodosContext> options)
            : base(options)
        {
        }

        public DbSet<MvcTodo.Models.Todo> Todo { get; set; }
    }
