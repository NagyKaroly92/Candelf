namespace BusinessLayer
{
    public class Mertekegyseg : IDisposable
    {
        public Mertekegyseg()
        {
                
        }

        public void Dispose()
        {
            
        }

        public string GetMertekegyseg()
        {
            string ret = string.Empty;

            using (var v = new DAL.MyDbContextFactory().CreateDbContext(null))
            {
                v.MennyisegiEgysegs.Add(new DAL.MennyisegiEgyseg { Megnevezes = "teszt1" });
                v.SaveChanges();

                foreach (var entity in v.MennyisegiEgysegs)
                {
                    ret = entity.Megnevezes;
                    v.MennyisegiEgysegs.Remove(entity);
                }
                v.SaveChanges();
            }

            return ret;
        }

    }
}
