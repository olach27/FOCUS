<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Coffee Time's News</title>
    <link rel="stylesheet" href="nav.css">
    <link rel="stylesheet" href="bcc.css">
    <style>
        body {
            font-family: Georgia, 'Times New Roman', Times, serif;
        }

        .container {
            max-width: 1200px;
            margin: 0 auto;
        }

        .containe {
            width: 20%;
            margin: 5px auto;
            padding: 2px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center;
        }

        .containe img {
            max-width: 100%;
            height: auto;
            border-radius: 1px;
            margin-bottom: 1px;
        }

        section {
            margin: 20px 0;
        }

        section h2 {
            border-bottom: 2px solid #ccc;
            padding-bottom: 5px;
        }

        .news-item {
            margin-bottom: 20px;
        }

        .news-item img {
            max-width: 100%;
            height: auto;
            border-radius: 4px;
        }
    </style>
</head>
<body>
    <header>
        <nav class="navbar">
            <div class="container">
                <div class="navbar-header">
                    <a class="navbar-brand" href="#"></a>
                </div>
                <div class="navbar-nav">                  
                    <a class="nav-item" href="https://www.facebook.com/profile.php?id=100012177063380&locale=ar_AR" target="_blank"><img src="fb.png" width="50" height="50" alt="Facebook"> </a>
                    <a class="nav-item" href="https://www.instagram.com/hachem_cheniour/" target="_blank"><img src="insta.webp" width="50" height="50" alt="Instagram"> </a>
                    <a class="nav-item" href="https://www.twitter.com" target="_blank"><img src="twitter.png" width="40" height="40" alt="Twitter"> </a>
                    <a class="nav-item"  href="login.html" target="_blank">Login</a>
                </div>
                <div class="navbar-search">
                    <input type="text" placeholder="Search...">
                    <button type="submit">Search</button>
                </div>
            </div>
        </nav>        
        <div> <iframe style="border-radius:12px" src="https://open.spotify.com/embed/playlist/37i9dQZF1DZ06evO03FbPP?utm_source=generator" width="20%" height="100" frameBorder="0" allowfullscreen="" allow="autoplay; clipboard-write; encrypted-media; fullscreen; picture-in-picture" loading="lazy"></iframe></div>
        <style>
            .category-images {
                display: flex;
                justify-content: space-between;
                margin-top: 20px;
                margin-bottom: 20px;
            }
    
            .category-image {
                width: 24%; 
                height: 50    ;
                cursor: pointer;
            }
    
            .category-image img {
                width: 100%;
                height: auto;
                border-radius: 4px;
            }
        </style>
    </head>
    <body>
        <header>
           
    
            <div class="containe">
                <img src="Deus_Coffee.png" alt="" width="100px" height="100px">
                <h1>Coffee Time's News</h1>
            </div>
    
            
            <div class="category-images">
                <div class="category-image">
                   <a href="politics.html" > <img src="t2.jpg" alt="Politics" onclick="navigateToCategory('politics')"></a>
                </div>
                <div class="category-image">
                    <a href="technologie.html"><img src="t3.jpg" alt="Technology" onclick="navigateToCategory('technology')"></a>
                </div>
                <div class="category-image">
                  <a href="sportive.html"> <img src="t1'.png" alt="Sports" onclick="navigateToCategory('sports')"></a> 
                </div>
                <div class="category-image">
                 <a href="art.html">   <img src="t3.png"  alt="Entertainment" onclick="navigateToCategory('entertainment')"></a>
                </div>
            </div>
        </header>
    
        <div class="container">
    
    

   

    <footer>
       <a href=""target="_blank"><p>&copy; 2023 Coffee Time News. Tous droits réservés. by hachem cheniour</p></a>
    </footer>
</body>
</html>

    