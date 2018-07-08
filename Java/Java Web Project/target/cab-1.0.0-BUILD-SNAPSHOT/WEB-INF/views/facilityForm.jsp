<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ page session="false" %>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>FacilityInsert</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Bitter:400,700">
    <link rel="stylesheet" href="assets/css/stylesfacility.min.min.css">
</head>

<body>
    <div>
        <nav class="navbar navbar-light navbar-expand-md navigation-clean" style="background-color:#444444;">
            <div class="container"><a class="navbar-brand" href="#" style="color:#ffffff;">Company Name</a><button class="navbar-toggler" data-toggle="collapse" data-target="#navcol-1"><span class="sr-only">Toggle navigation</span><span class="navbar-toggler-icon"></span></button>
                <div
                    class="collapse navbar-collapse" id="navcol-1">
                    <ul class="nav navbar-nav ml-auto">
                        <li class="nav-item" role="presentation"><a class="nav-link active" href="#" style="color:#ffffff;">First Item</a></li>
                        <li class="nav-item" role="presentation"><a class="nav-link" href="#" style="color:#ffffff;">Second Item</a></li>
                        <li class="nav-item" role="presentation"><a class="nav-link" href="#" style="color:#ffffff;">Third Item</a></li>
                    </ul>
            </div>
    </div>
    </nav>
    </div>
    <div class="contact-clean">
        <form method="post">
            <h2 class="text-center">Facility</h2>
            <div class="form-group"><input class="form-control" type="text" name="name" required="" placeholder="Name"></div>
            <div class="form-group"><input class="form-control" type="text" name="description" placeholder="Description"></div>
            <div class="form-group"><textarea class="form-control" rows="14" name="remark" placeholder="Remark"></textarea></div>
            <div class="form-group"><button class="btn btn-primary" type="button">Add</button><button class="btn btn-primary" type="button">Cancel</button></div>
        </form>
    </div>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0/js/bootstrap.bundle.min.js"></script>
</body>
</html>
