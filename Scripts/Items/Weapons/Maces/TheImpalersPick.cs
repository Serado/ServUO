using System;

namespace Server.Items
{
    [FlipableAttribute(0x143D, 0x143C)]
    public class TheImpalersPick : HammerPick
    {
        [Constructable]
        public TheImpalersPick()
        {
            this.Name = ("The Impaler's Pick");
		
            this.Hue = 2101;	
		
            this.WeaponAttributes.HitManaDrain = 10;
            this.Slayer = SlayerName.Repond;
            this.WeaponAttributes.HitLightning = 40;
            this.WeaponAttributes.HitLowerDefend = 40;
            this.Attributes.WeaponSpeed = 30;
            this.Attributes.WeaponDamage = 45;	
        }

        public TheImpalersPick(Serial serial)
            : base(serial)
        {
        }

		public override int AosMinDamage
		{
			get
			{
				return 15;
			}
		}

		public override int AosMaxDamage
		{
			get
			{
				return 17;
			}
		}

		public override float MlSpeed
		{
			get
			{
				return 3.75f;
			}
		}

        public override int InitMinHits
        {
            get
            {
                return 255;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 255;
            }
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}