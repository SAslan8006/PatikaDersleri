import "./App.css";
import Header from "./Components/Header";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import { Container } from "react-bootstrap";
import HomeScreen from "./Screens/HomeScreen";
import AuthScreen from "./Screens/AuthScreen";
import SignUpScreen from "./Screens/SignUpScreen";
import { useState } from "react";

function App() {
  const [user, setUser] = useState(null);
  return (
    <Router>
      <Header user={user} setUser={setUser} />
      <main className="py-3">
        <Container>
          <Routes>
            <Route path="/" element={<HomeScreen user={user} />} exact />
            <Route path="/signin" element={<AuthScreen setUser={setUser} />} />
            <Route path="/signup" element={<SignUpScreen />} />
          </Routes>
        </Container>
      </main>
    </Router>
    /* Selam */
  );
}

export default App;
