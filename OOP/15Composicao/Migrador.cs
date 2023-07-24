using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _15Composicao;

internal class Migrador
{
    public DateTime DataHora { get; set; }

    private readonly Logger _logger;

    public Migrador(Logger logger)
    {
        _logger = logger;
    }

    public void Migrar()
    {
        _logger.Log($"Migrando em : {DataHora}");
    }

}
