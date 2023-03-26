import React from "react";

const HomeScreen = ({ user }) => {
  return <div>{user?.email}</div>;
};

export default HomeScreen;
