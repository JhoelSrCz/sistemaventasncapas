namespace SistemaVentas.VISTA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PersonasVistas.PersonaListarVista());
            Application.Run(new RolVistas.RolListarVistas());
            Application.Run(new TipoProdVistas.TipoProdListarVistas());
            Application.Run(new MarcaVistas.MarcaListarVistas());
            Application.Run(new UsuarioVistas.UsuarioListarVistas());
            Application.Run(new UsuarioRolVistas.UsuarioRolListarVistas());
            Application.Run(new ClienteVistas.ClienteListarVistas());
            Application.Run(new IngresoVistas.IngresoListarVistas());
            Application.Run(new VentaVistas.VentaListarVistas());
            Application.Run(new ProductoVistas.ProductoListarVistas());
            Application.Run(new ProveeVistas.ProveeListarVistas());
            Application.Run(new DetalleVentaVistas.DetalleVentaListarVistas());
            Application.Run(new DetalleIngVistas.DetalleIngListarVistas());
        }
    }
}