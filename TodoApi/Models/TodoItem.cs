using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models {
    /// <summary>
    /// This class file holds the data about work we need to do.
    /// </summary>
    public class TodoItem {

        /// <summary>
        /// Gets or sets the specific TodoItem.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the name of TodoItem.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this TodoItem is complete.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this TodoItem is complete; otherwise, <c>false</c>.
        /// </value>
        [DefaultValue(false)]
        public bool IsComplete { get; set; }
    }
}
