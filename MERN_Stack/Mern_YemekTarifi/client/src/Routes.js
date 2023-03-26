import { Route, BrowserRouter as Router, Switch } from "react-router-dom";

import { AddIngredientPage } from "./ingredients";
import { AddMealPage } from "./meals";
import { AddStepPage } from "./steps";
import { HomePage } from "./home";
import React from "react";

const routes = [
  {
    path: "/",
    Component: HomePage,
    exact: true,
  },
  {
    path: "/add-meal",
    Component: AddMealPage,
  },
  {
    path: "/add-ingredient",
    Component: AddIngredientPage,
  },
  {
    path: "/add-step",
    Component: AddStepPage,
  },
];

export const Routes = () => (
  <Router>
    <Switch>
      {routes.map((route, index) => (
        <Route key={index} path={route.path} exact={route.exact}>
          <route.Component />
        </Route>
      ))}
    </Switch>
  </Router>
);
