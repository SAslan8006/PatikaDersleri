import React, { useState, useEffect } from "react";
import { Container, Form, Button, FormGroup, Row, Col } from "react-bootstrap";
import { Link, useNavigate } from "react-router-dom";
import "react-phone-number-input/style.css";
import { register } from "../axios";

const SignUpScreen = () => {
  const navigate = useNavigate();
  const [formData, setFormData] = useState({
    fullname: "",
    password: "",
    phoneNumber: "",
    email: "",
  });
  return (
    <Container>
      <Row className="justify-content-center">
        <Col xs={12} md={6}>
          <Form
            onSubmit={(e) => {
              e.preventDefault();

              register(formData)
                .then((res) => {
                  navigate("/signin");
                })
                .catch((err) => console.log(err));
            }}
          >
            <Form.Group className="mb-3" controlId="formBasicName">
              <Form.Label>Full Name</Form.Label>
              <Form.Control
                onChange={(e) =>
                  setFormData({ ...formData, fullname: e.target.value })
                }
                type="name"
                placeholder="Enter your name"
              />
            </Form.Group>
            <Form.Group className="mb-3" controlId="formBasicEmail">
              <Form.Label>Email address</Form.Label>
              <Form.Control
                onChange={(e) =>
                  setFormData({ ...formData, email: e.target.value })
                }
                type="email"
                placeholder="Enter email"
              />
            </Form.Group>
            <Form.Group className="mb-3" controlId="formBasicPassword">
              <Form.Label>Password</Form.Label>
              <Form.Control
                onChange={(e) =>
                  setFormData({ ...formData, password: e.target.value })
                }
                type="password"
                placeholder="Enter password"
              />
            </Form.Group>
            <Form.Group className="mb-3" controlId="formBasicPassword">
              <Form.Label>Password Again</Form.Label>
              <Form.Control
                type="password"
                placeholder="Enter your password again"
              />
            </Form.Group>
            <Form.Group className="mb-3" controlId="formBasicPassword">
              <Form.Label>Phone</Form.Label>
              <Form.Control
                onChange={(e) =>
                  setFormData({ ...formData, phoneNumber: e.target.value })
                }
                placeholder="Phone number"
              />
            </Form.Group>
            <Form.Group className="d-grid">
              <Button variant="primary" type="submit" className="mt-4">
                <Link className="text-white text-decoration-none" to="/auth">
                  Sign Up
                </Link>
              </Button>
            </Form.Group>
          </Form>
        </Col>
      </Row>
    </Container>
  );
};
export default SignUpScreen;
