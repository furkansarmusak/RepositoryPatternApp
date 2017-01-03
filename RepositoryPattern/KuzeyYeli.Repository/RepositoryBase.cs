using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuzeyYeli.ORM.Models;


namespace KuzeyYeli.Repository
{
    public class RepositoryBase<T> where T:class
    {
            private static KuzeyYeliContext context;
            //Singleton Pattern
	        public KuzeyYeliContext Context
	        {
		        get {
                        if(context ==null)
                        context = new KuzeyYeliContext();
                        return context;
                   }
		        set { context = value;}
	        }
	
            public IList<T> Listele()
            {   
                return Context.Set<T>().ToList();    
            }
            public void Ekle(T Entity)
            {
                Context.Set<T>().Add(Entity);
                Context.SaveChanges();
                Context = new KuzeyYeliContext();
            }
            public void Sil(T Entity)
            {
                Context.Set<T>().Remove(Entity);
                Context.SaveChanges();
                Context = new KuzeyYeliContext(); 
            }
            public void Guncelle()
            {
                Context.SaveChanges();
            
            }
    }
}
