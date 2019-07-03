using System;
using System.Collections.Generic;
using System.Text;

namespace IU.Planning.ConApp.Models
{
    /// <summary>
    /// Событие
    /// </summary>
    public class Event : IEntity
    {
        /// <summary>
        /// ctor
        /// </summary>
     public Event()
        {
            Uid = Guid.NewGuid();
}
     /// <inheritdoc/>
        public Guid Uid { get; set; }

        /// <summary>
        /// Заголовок
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Начало события
        /// </summary>

        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Конец события
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Место события
        /// </summary>
        public string Place { get; set; }


    }
}
