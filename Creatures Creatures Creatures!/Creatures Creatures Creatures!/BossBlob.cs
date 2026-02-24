using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatures_Creatures_Creatures_
{
    public class BossBlob : Blob
    {
        
        // I'm thinking that boss blobs will be very similar to normal blobs, but they'll be able to use different projectiles, just like the player...
        public List<Projectile> Projectiles = new List<Projectile>();
        
        public BossBlob() 
        { 
        }
    }
}
