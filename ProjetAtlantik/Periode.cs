using System;

internal class Periode
{
    private int _noPeriode;
    private DateTime _dateDebut;
    private DateTime _dateFin;

    public Periode(int noPeriode, DateTime dateDebut, DateTime dateFin)
    {
        _noPeriode = noPeriode;
        _dateDebut = dateDebut;
        _dateFin = dateFin;
    }

    public int GetID()
    {
        return _noPeriode;
    }

    public override string ToString() => $"{_dateDebut:dd/MM/yyyy} - {_dateFin:dd/MM/yyyy}";
}
