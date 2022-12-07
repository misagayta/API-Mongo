using ApiMongo.Models;
using MongoDB.Deriver;
using System.Collections.Generic;
using System.Linq;

namespace ApiMongo Services
{

    public class EscuelaServices
    {
	    private IMongoConllection<Alumnos> _alumnos;

	    public EscuelaServices(IEscuelaSettings settings)
	    {
		    var cliente = new MongiClient(settings.Server);
		    var database = cliente GetDatabase(settings.Database);
		    _alumnos = database.GetCollection<Alumnos>(settings.Collection);

	    }
	    public List<Alumnos> Get()
	    {
		    return _alumnos.Find(d => true).ToList();
	    }
	    public Alumnos Create(Alumnos alumnos)
	    {
		   _alumnos.InsertOne(alumnos);
		   return alumnos;
	    }
	    public void Update(string id, Alumnos alumnos) 
	    {
		_alumnos.ReplaceOne(alumnos => alumnos.Id == id, alumnos);
	    }
	public void Delete(string id)
	{
		_alumnos.DeleteOne(d => d.Id == id);
	}
    }
}
