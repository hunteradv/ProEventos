using System.Collections;
using System.Collections.Generic;

namespace ProEventos.Domain
{
    public class Speaker
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string MiniResume { get; set; }
        public string ImageURL { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public IEnumerable<SocialNetwork> SocialsNetworks { get; set; }
        public IEnumerable<SpeakerEvent> SpeakersEvents { get; set; }        
    }
}