using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models {
    /// <summary>
    /// This class file is responsible for communication with underlying database.
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class TodoContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TodoContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) {

        }

        /// <summary>
        /// Gets or sets the todo items.
        /// </summary>
        /// <value>
        /// The todo items.
        /// </value>
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
