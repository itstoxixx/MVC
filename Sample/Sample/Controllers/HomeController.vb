Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
    Function Seminar() As ActionResult
        ViewData("Message") = "You can add Seminars here."

        Return View()
    End Function
    Function Workshop() As ActionResult
        ViewData("Message") = "You can add Workshop here."

        Return View()
    End Function
    Function Exhibit() As ActionResult
        ViewData("Message") = "You can add Exhibits here."

        Return View()
    End Function
End Class
