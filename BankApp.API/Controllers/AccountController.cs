using BankApp.API.Entities;
using BankApp.API.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IAccountRepository _accountRepository;

        public AccountController(ILogger<AccountController> logger, IAccountRepository accountRepository)
        {
            _logger = logger;
            _accountRepository = accountRepository;
        }

        [Route("GetAllAccounts")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetAllAccounts()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            try
            {
                var lstAccounts = await _accountRepository.GetAllAccounts();
                if (lstAccounts == null)
                {
                    var showmessage = "Empty Account List";
                    dict.Add("Message", showmessage);
                    return Ok(dict);

                }
                else
                {
                    return new OkObjectResult(lstAccounts);
                }

            }
            catch (Exception ex)
            {

                var showmessage = "Erreur" + ex.ToString();
                dict.Add("Message", showmessage);
                return BadRequest(dict);
            }
        }

        [Route("GetAccountById")]
        [HttpGet]
        public async Task<ActionResult<Account>> GetAccountById(int id)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            try
            {
                var acc = await _accountRepository.GetAccountById(id);
                if (acc != null)
                {
                    return new OkObjectResult(acc);

                }
                else
                {
                    var showmessage = "Account not found";
                    dict.Add("Message", showmessage);
                    return Ok(dict);

                }

            }
            catch (Exception ex)
            {

                var showmessage = "Erreur" + ex.ToString();
                dict.Add("Message", showmessage);
                return BadRequest(dict);
            }
        }

        [Route("AddAccount")]
        [HttpPost]
        public async Task<ActionResult<bool>> AddAccount(Account account)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            try
            {
                var res = await _accountRepository.AddAccount(account);
                if (res == true)
                {
                    var showmessage = "Account added successfully!";
                    dict.Add("Message", showmessage);
                    return Ok(dict);

                }
                else
                {
                    var showmessage = "Error";
                    dict.Add("Message", showmessage);
                    return Ok(dict);

                }

            }
            catch (Exception ex)
            {

                var showmessage = "Error" + ex.ToString();
                dict.Add("Message", showmessage);
                return BadRequest(dict);
            }
        }
    }
}
