using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MuonSach
{
    class Modify
    {
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public Modify()
        {
        }
        public DataView getAllPMuon()
        {
            DataView dataView = new DataView();
            string query = "select * from PhieuMuon";
            using (SqlConnection sqlConnection = FormPhieuMuon.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                //dataAdapter.Fill(dataView);
                sqlConnection.Close();
            }
            return dataView;
        }

        public bool insert(Muon PhieuMuon)
        {
            SqlConnection sqlConnection = FormPhieuMuon.getConnection();
            string query = "insert into PhieuMuon values(@MaPhieu,@MaDocGia,@MaGT,@NgayMuon,@NgayPhaiTra,@TinhTrangMuon)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaPhieu", SqlDbType.NVarChar).Value = PhieuMuon.MaPhieuMuon;
                sqlCommand.Parameters.Add("@MaDocGia", SqlDbType.NVarChar).Value = PhieuMuon.MaDocGia;
                sqlCommand.Parameters.Add("@MaGT", SqlDbType.NVarChar).Value = PhieuMuon.MaSach;
                sqlCommand.Parameters.Add("@NgayMuon", SqlDbType.NVarChar).Value = PhieuMuon.NgayMuon.ToShortDateString();
                sqlCommand.Parameters.Add("@NgayPhaiTra", SqlDbType.NVarChar).Value = PhieuMuon.NgayPhaiTra.ToShortDateString();
                sqlCommand.Parameters.Add("@TinhTrangMuon", SqlDbType.NVarChar).Value = PhieuMuon.TinhTrangSach;
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool update(Muon PhieuMuon)
        {
            SqlConnection sqlConnection = FormPhieuMuon.getConnection();
            string query = "update PhieuMuon set" +
                " MaPhieu = @MaPhieu, MaDocGia = @MaDocGia, MaGT = @MaGT, NgayMuon = @NgayMuon, NgayPhaiTra = @NgayPhaiTra, TinhTrangMuon = @TinhTrangMuon " +
                "where MaPhieu = @MaPhieu";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaPhieu", SqlDbType.NVarChar).Value = PhieuMuon.MaPhieuMuon;
                sqlCommand.Parameters.Add("@MaDocGia", SqlDbType.NVarChar).Value = PhieuMuon.MaDocGia;
                sqlCommand.Parameters.Add("@MaGT", SqlDbType.NVarChar).Value = PhieuMuon.MaSach;
                sqlCommand.Parameters.Add("@NgayMuon", SqlDbType.NVarChar).Value = PhieuMuon.NgayMuon.ToShortDateString();
                sqlCommand.Parameters.Add("@NgayPhaiTra", SqlDbType.NVarChar).Value = PhieuMuon.NgayPhaiTra.ToShortDateString();
                sqlCommand.Parameters.Add("@TinhTrangMuon", SqlDbType.NVarChar).Value = PhieuMuon.TinhTrangSach;
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool delele(Muon PhieuMuon)
        {
            SqlConnection sqlConnection = FormPhieuMuon.getConnection();
            string query = "delete PhieuMuon where MaPhieu = @MaPhieu";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaPhieu", SqlDbType.NVarChar).Value = PhieuMuon.MaPhieuMuon;
                sqlCommand.Parameters.Add("@MaDocGia", SqlDbType.NVarChar).Value = PhieuMuon.MaDocGia;
                sqlCommand.Parameters.Add("@MaGT", SqlDbType.NVarChar).Value = PhieuMuon.MaSach;
                sqlCommand.Parameters.Add("@NgayMuon", SqlDbType.NVarChar).Value = PhieuMuon.NgayMuon.ToShortDateString();
                sqlCommand.Parameters.Add("@NgayPhaiTra", SqlDbType.NVarChar).Value = PhieuMuon.NgayPhaiTra.ToShortDateString();
                sqlCommand.Parameters.Add("@TinhTrangMuon", SqlDbType.NVarChar).Value = PhieuMuon.TinhTrangSach;
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
    }
}
