using System;

namespace DemoMediacion.Models
{
    public class GuitarHistory
    {
        public int Id { get; set; }

        public ActionType Action { get; set; }

        public DateTime Date { get; }

        public Guitar Guitar { get; set; }

        public GuitarHistory(ActionType action)
        {
            Action = action;
            Date = DateTime.Now;
        }
    }
}
