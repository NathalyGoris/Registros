using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class TicketsDetalleBLL
{
    private readonly Context _context;

    public TicketsDetalleBLL(Context context)
    {
        _context = context;
    }

    public bool Existe(int TicketId)
    {
        return _context.TicketsDetalle.Any(o => o.TicketId == TicketId);
    }

    private bool Insertar(TicketsDetalle TicketsDetalle)
    {
        _context.TicketsDetalle.Add(TicketsDetalle);
        return _context.SaveChanges() > 0;
    }

    private bool Modificar(TicketsDetalle TicketsDetalle)
    {
        var existe = _context.TicketsDetalle.Find(TicketsDetalle.TicketId);
        if(existe != null)
        {
            _context.Entry(existe).CurrentValues.SetValues(TicketsDetalle);
            return _context.SaveChanges() > 0;
        }

        return false;
    }

    public bool Guardar(TicketsDetalle TicketsDetalle){
        if(!Existe(TicketsDetalle.TicketId))
            return this.Insertar(TicketsDetalle);
        else
            return this.Modificar(TicketsDetalle);
    }

    public bool Eliminar(int TicketId)
    {
        var eliminado  = _context.TicketsDetalle.Where(o=> o.TicketId == TicketId).SingleOrDefault();

        if(eliminado!=null){
            _context.Entry(eliminado).State = EntityState.Deleted;
            return _context.SaveChanges() > 0;
        }
        return false;
    }

    public TicketsDetalle? Buscar(int TicketId)
    {
        return _context.TicketsDetalle.Where(o => o.TicketId == TicketId).AsNoTracking().SingleOrDefault();
    }

    public List<TicketsDetalle> GetList(Expression<Func<TicketsDetalle, bool>> criterio)
    {
        return _context.TicketsDetalle.AsNoTracking().Where(criterio).ToList();
    }
    public bool VerificarExistencia(TicketsDetalle TicketsDetalle)
    {
        var TicketIgual = _context.TicketsDetalle.Any(o =>o.TicketId == TicketsDetalle.TicketId);

        if(TicketIgual)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}   
