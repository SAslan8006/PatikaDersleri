import React, { useEffect } from "react";
import { Navbar, Nav, Container, Button, NavDropdown } from "react-bootstrap";
import { Link } from "react-router-dom";
const Header = ({ user, setUser }) => {
  useEffect(() => {
    if (localStorage.getItem("user") && !user) {
      setUser(JSON.parse(localStorage.getItem("user")));
    }
  }, [user]);
  return (
    <Navbar className="py-4 " bg="primary" expand="lg">
      <Container>
        <Navbar.Brand className="text-white">IEU ACM</Navbar.Brand>
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav">
          <Nav className="me-auto">
            <Nav.Link className="text-white">Anasayfa</Nav.Link>
            <Nav.Link></Nav.Link>
            <NavDropdown
              title={<span className="text-white">Hakkımızda</span>}
              id="basic-nav-dropdown"
            >
              <NavDropdown.Item>ACM Nedir</NavDropdown.Item>
              <NavDropdown.Item>Neler Yapıyoruz</NavDropdown.Item>
              <NavDropdown.Item>Ekibimiz</NavDropdown.Item>
              <NavDropdown.Divider />
            </NavDropdown>
            <Nav.Link className="text-white">Duyurular</Nav.Link>
            <Nav.Link className="text-white">Blog</Nav.Link>
            <Nav.Link className="text-white">İletişim</Nav.Link>
          </Nav>
        </Navbar.Collapse>
        {user ? (
          <Button
            variant="outline-light"
            onClick={(e) => {
              localStorage.removeItem("user");
              setUser(null);
            }}
          >
            {" "}
            Çıkış yap{" "}
          </Button>
        ) : (
          <Button variant="outline-light">
            <Link className="text-white text-decoration-none" to="/signin">
              Giriş yap
            </Link>
          </Button>
        )}
      </Container>
    </Navbar>
  );
};

export default Header;
