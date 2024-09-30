using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateAuction.DAL;
using RealEstateAuction.DataModel;
using RealEstateAuction.Models;
using System.Security.Claims;


namespace RealEstateAuction.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserDAO userDAO;
        private readonly AuctionDAO auctionDAO;
        private readonly BankDAO bankDAO;
        private readonly PaymentDAO paymentDAO;
        private readonly TicketDAO ticketDAO;
        private readonly AuctionBiddingDAO auctionBiddingDAO;
        private readonly CategoryDAO categoryDAO;
        private IMapper _mapper;
        private Pagination pagination;
        private NotificationDAO notificationDAO;

        public AccountController(IMapper mapper)
        {
            pagination = new Pagination();
            auctionDAO = new AuctionDAO();
            userDAO = new UserDAO();
            _mapper = mapper;
            bankDAO = new BankDAO();
            paymentDAO = new PaymentDAO();
            ticketDAO = new TicketDAO();
            auctionBiddingDAO = new AuctionBiddingDAO();
            categoryDAO = new CategoryDAO();
            notificationDAO = new NotificationDAO();
        }


    }
}
