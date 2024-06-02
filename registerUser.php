<!-- <?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "aranxhatadreamchronicles";

$loginUser = $_POST["loginUser"];
$loginPass = $_POST["loginPass"];
$redMail = $_POST["regMail"];

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}
echo "Connected successfully";


$sql = "SELECT username FROM players WHERE name = '". $loginUser . "' " ;
$result = $conn->query($sql);

if ($result->num_rows > 0) {
  // tell user name is alreay taken
  echo "Username already exists."
  
} else {
  echo "Creating user";   
    $sql2 = "INSERT INTO players(name, email, password )
    VALUES ('". $loginUser . "', '". $regMail . "', '". $loginPass . "')"; 

    
if ($conn->query($sql2) === TRUE) {
    echo "New record created successfully";
  } else {
    echo "Error: " . $sql2. "<br>" . $conn->error;
  }
}
$conn->close();

?> -->

<!-- <?php
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Headers: *");
header("Access-Control-Allow-Methods: POST");
error_reporting(E_ALL);
ini_set('display_errors', 1);

$servername = "localhost";
$username = "root";
$password = "";
$dbname = "aranxhatadreamchronicles";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Get the data from the POST request
$loginUser = $_POST["loginUser"];
$loginPass = $_POST["loginPass"];
$regMail = $_POST["regMail"];

// Check if username already exists
$sql = "SELECT username FROM players WHERE name = ?";
$stmt = $conn->prepare($sql);
$stmt->bind_param("s", $loginUser);
$stmt->execute();
$stmt->store_result();

if ($stmt->num_rows > 0) {
    echo json_encode(["success" => false, "message" => "Username already exists."]);
} else {
    // Insert new user
    $sql2 = "INSERT INTO players (name, email, password) VALUES (?, ?, ?)";
    $stmt2 = $conn->prepare($sql2);
    $stmt2->bind_param("sss", $loginUser, $regMail, $loginPass);

    if ($stmt2->execute()) {
        echo json_encode(["success" => true, "message" => "New record created successfully"]);
    } else {
        echo json_encode(["success" => false, "message" => "Error: " . $stmt2->error]);
    }
}

$stmt->close();
$stmt2->close();
$conn->close();
?> -->

<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "user_registration";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Check if POST request
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $user = $_POST['username'];
    $email = $_POST['email'];
    $pass = password_hash($_POST['password'], PASSWORD_BCRYPT);

    $sql = "INSERT INTO users (username, email, password) VALUES ('$user', '$email', '$pass')";

    if ($conn->query($sql) === TRUE) {
        echo "Registration successful";
    } else {
        echo "Error: " . $sql . "<br>" . $conn->error;
    }
}

$conn->close();
?>
