using System;
using System.Collections.Generic;

namespace ProEventos.Domain
{
    public class Event
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime? EventDate { get; set; }
        public string Title { get; set; }
        public int PeopleQuantity { get; set; } 
        public string ImageUrl { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public IEnumerable<Batch> Batch { get; set; }
        public IEnumerable<SocialNetwork> SocialsNetworks { get; set; }
        public IEnumerable<SpeakerEvent> SpeakersEvents { get; set; }
    }
}