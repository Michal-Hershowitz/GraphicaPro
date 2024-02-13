import logo from "./logo.svg";
import "./App.css";
import { BrowserRouter, Route, Link, Routes } from "react-router-dom";
import API from "./Variables";
import axios from "axios";
import { useEffect } from "react";
import { urlCustomer } from "./endpoints";
import Employee from "./components/Employee";
// import { create } from "jss";
// import rtl from "jss-rtl";
// import { StylesProvider, jssPreset } from "@mui/styles";
import { createTheme, ThemeProvider } from "@mui/material/styles";
import rtlPlugin from "stylis-plugin-rtl";
import { prefixer } from "stylis";
import { CacheProvider } from "@emotion/react";
import createCache from "@emotion/cache";
// import { StyleSheetManager } from "styled-components";
import WorkingHours from "./components/WorkingHours";
// import Login from "./components/login";
import Sign_in from "./components/Sign_inEmployee";
import Login_inEmployee from "./components/Login_inEmployee";
import Customer from "./components/Customer";
import Contract from "./components/Contract";
import Job_Status from "./components/Job_Status";
import Payment from "./components/Payment";
import Download from "./components/Download";
import Chat from "./components/Chat";
import Login_inCustomer from "./components/Sign_inCustomer";
import Sign_inCustomer from "./components/Login_inCustomer";


function App() {
  const theme = createTheme({
    direction: "rtl",
  });
  const cacheRtl = createCache({
    key: "muirtl",
    stylisPlugins: [prefixer, rtlPlugin],
  });

  // const jss = create({
  //   plugins: [...jssPreset().plugins, rtl()],
  // });
  useEffect(() => {
    axios.get(urlCustomer).then((response) => {
      console.log(response.data);
    });
  }, []);
  // const user = {
  //   id: "123456789123456789123456",
  //   name: "racheli",
  // };
  const deleteClick = async () => {
    try {
      // const response = await API.post(`Employee`, user);
      const response = await API.get(`Customer`);
      console.log(response.data);
    } catch (error) {
      console.log(error);
    }
  };

  return (
    <div className="App">
      <body>
        {/* <Provider store={store}> */}
        <BrowserRouter>
          {/* <NavBar></NavBar> */}
          <Routes>
            <Route
              exact
              path="/"
              element={<Login_inCustomer></Login_inCustomer>}
            />
            {/* <Route
              exact
              path="/"
              element={<Sign_inCustomer></Sign_inCustomer>}
            /> */}

            <Route exact path="/Customer" element={<Customer></Customer>} />
            <Route exact path="/Contract" element={<Contract></Contract>} />
            <Route
              exact
              path="/Job_Status"
              element={<Job_Status></Job_Status>}
            />
            <Route exact path="/Payment" element={<Payment></Payment>} />
            <Route exact path="/Download" element={<Download></Download>} />
            {/* <Route
              exact
              path="/Insurance/:id"
              element={<AddFanix></AddFanix>}
            /> */}

            {/* <Route
              exact
              path="/Plaaaaaace/:amount"
              element={<Plaaaaaace></Plaaaaaace>}
            /> */}
            {/* <Route
              exact
              path="/GoToPayment/:amount"
              element={<GoToPayment></GoToPayment>}
            /> */}
            {/* <Route exact path="/MyVideoComponent/" element={<MyVideoComponent></MyVideoComponent>} /> */}
          </Routes>
        </BrowserRouter>
        {/* </Provider> */}
      </body>
    </div>

    // <CacheProvider value={cacheRtl}>
    //   <ThemeProvider theme={theme}>
    //     {/* <StyleSheetManager stylisPlugins={[rtlPlugin]}> */}
    //     {/* <StylesProvider jss={jss}> */}
    //     <div dir="rtl">
    //       <div className="App">
    //         <header className="App-header">
    //           {/* <Employee></Employee> */}
    //           {/* <Login_inEmployee></Login_inEmployee> */}
    //           <Customer></Customer>
    //           {/* <Sign_in></Sign_in> */}
    //           {/* <WorkingHours></WorkingHours> */}
    //           {/* <button onClick={deleteClick}>delete</button> */}
    //         </header>
    //       </div>
    //     </div>
    //     {/* </StylesProvider>
    //        </StyleSheetManager> */}
    //   </ThemeProvider>
    // </CacheProvider>
  );
}

export default App;
