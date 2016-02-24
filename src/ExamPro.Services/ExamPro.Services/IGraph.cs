using ExamPro.Domain.Models;
using System;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExamPro.Services
{
    public interface IGraph
    {
        Chart Chart { get; set; }
        void LoadData(Patient Patient); // ExamsChart
        void SetTitle(string p);        
        void DefineColors();
        void UpdateSettings();
    }

    public enum eSettings
    {
        Area, Res, Marca, Font
    }

    public interface iSettings
    {
        string Title { get; set; }
        Color Res { get; set; }
        Color Marca { get; set; }
        Color Area { get; set; }
        Color Font { get; set; }
        void Default();
        void Undo();
    }
}
