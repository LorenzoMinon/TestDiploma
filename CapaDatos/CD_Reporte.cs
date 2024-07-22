using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Reporte
    {
        public List<ReporteComprasPorProveedor> ReporteComprasPorProveedor()
        {
            List<ReporteComprasPorProveedor> lista = new List<ReporteComprasPorProveedor>();

            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ReporteComprasPorProveedor", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteComprasPorProveedor()
                            {
                                Proveedor = dr["Proveedor"].ToString(),
                                TotalComprado = Convert.ToDecimal(dr["TotalComprado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteComprasPorProveedor>();
                }
            }

            return lista;
        }

        public List<ReporteCantidadCompradaPorProducto> ReporteCantidadCompradaPorProducto()
        {
            List<ReporteCantidadCompradaPorProducto> lista = new List<ReporteCantidadCompradaPorProducto>();

            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ReporteCantidadCompradaPorProducto", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteCantidadCompradaPorProducto()
                            {
                                Producto = dr["Producto"].ToString(),
                                CantidadComprada = Convert.ToInt32(dr["CantidadComprada"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteCantidadCompradaPorProducto>();
                }
            }

            return lista;
        }

        public List<ReporteGananciaPotencialPorProducto> ReporteGananciaPotencialPorProducto()
        {
            List<ReporteGananciaPotencialPorProducto> lista = new List<ReporteGananciaPotencialPorProducto>();

            using (SqlConnection conexion = new SqlConnection(Conexion.Instancia.Cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ReporteGananciaPotencialPorProducto", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteGananciaPotencialPorProducto()
                            {
                                Producto = dr["Producto"].ToString(),
                                GananciaPotencial = Convert.ToDecimal(dr["GananciaPotencial"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteGananciaPotencialPorProducto>();
                }
            }

            return lista;
        }
    }
}
