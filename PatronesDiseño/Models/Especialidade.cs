﻿using System;
using System.Collections.Generic;

namespace PatronesDiseño.models;

public partial class Especialidade
{
    public int Idespecialidad { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Medico> Medicos { get; set; } = new List<Medico>();
}
