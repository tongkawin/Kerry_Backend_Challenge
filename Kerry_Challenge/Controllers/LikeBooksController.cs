using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Kerry_Challenge.Models;
using System.Data;
using Kerry_Challenge.Auth;

namespace Kerry_Challenge.Controllers
{
    public class LikeBooksController : Controller
    {
        SqlConnection conn;
        SqlCommand cmd;

        [HttpPost]
        [Route("/user/like")]
        public async Task<IActionResult> LikeBooks([FromBody] LikeBooksModel model)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Catalog=LikeBookDB;Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                conn.Open();
                cmd = new SqlCommand("INSERT INTO LikeBooks (user_id, book_id) VALUES (@user_id, @book_id)", conn);
                cmd.Parameters.AddWithValue("@user_id", model.user_id);
                cmd.Parameters.AddWithValue("@book_id", model.book_id);
                cmd.ExecuteNonQuery();
                return Ok(new Response { Status = "Success", Message = "Book liked successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}



