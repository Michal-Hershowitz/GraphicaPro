import * as React from "react";
import { styled, useTheme } from "@mui/material/styles";
import Box from "@mui/material/Box";
import MuiDrawer from "@mui/material/Drawer";
import MuiAppBar from "@mui/material/AppBar";
import Toolbar from "@mui/material/Toolbar";
import List from "@mui/material/List";
import CssBaseline from "@mui/material/CssBaseline";
import Typography from "@mui/material/Typography";
import Divider from "@mui/material/Divider";
import IconButton from "@mui/material/IconButton";
import MenuIcon from "@mui/icons-material/Menu";
import ChevronLeftIcon from "@mui/icons-material/ChevronLeft";
import ChevronRightIcon from "@mui/icons-material/ChevronRight";
import ListItem from "@mui/material/ListItem";
import ListItemButton from "@mui/material/ListItemButton";
import ListItemIcon from "@mui/material/ListItemIcon";
import ListItemText from "@mui/material/ListItemText";
import InboxIcon from "@mui/icons-material/MoveToInbox";
import MailIcon from "@mui/icons-material/Mail";
import DescriptionRoundedIcon from "@mui/icons-material/DescriptionRounded";
import ChecklistRtlRoundedIcon from "@mui/icons-material/ChecklistRtlRounded";
import CreditScoreRoundedIcon from "@mui/icons-material/CreditScoreRounded";
import TextsmsRoundedIcon from "@mui/icons-material/TextsmsRounded";

import Card from "@mui/material/Card";
import CardContent from "@mui/material/CardContent";
import CardMedia from "@mui/material/CardMedia";
import { CardActionArea } from "@mui/material";
import { useNavigate } from "react-router-dom";

import Button from "@mui/material/Button";
import Snackbar from "@mui/material/Snackbar";
import CloseIcon from "@mui/icons-material/Close";

import Chat from "./Chat";
import Tooltip from "@mui/material/Tooltip";

function Customer() {
  const navigate = useNavigate();

  const [openChat, setOpenChat] = React.useState(false);

  const handleClick = () => {
    setOpenChat(true);
  };

  const handleClose = (event, reason) => {
    if (reason === "clickaway") {
      return;
    }

    setOpenChat(false);
  };

  const action = (
    <React.Fragment>
      {/* <Button color="secondary" size="small" onClick={handleClose}>
         UNDO
       </Button> */}
      <IconButton
        size="small"
        aria-label="close"
        color="inherit"
        onClick={handleClose}
      >
        <CloseIcon fontSize="small" />
      </IconButton>
    </React.Fragment>
  );
  
  const drawerWidth = 240;

  const openedMixin = (theme) => ({
    width: drawerWidth,
    transition: theme.transitions.create("width", {
      easing: theme.transitions.easing.sharp,
      duration: theme.transitions.duration.enteringScreen,
    }),
    overflowX: "hidden",
  });

  const closedMixin = (theme) => ({
    transition: theme.transitions.create("width", {
      easing: theme.transitions.easing.sharp,
      duration: theme.transitions.duration.leavingScreen,
    }),
    overflowX: "hidden",
    width: `calc(${theme.spacing(7)} + 1px)`,
    [theme.breakpoints.up("sm")]: {
      width: `calc(${theme.spacing(8)} + 1px)`,
    },
  });

  const DrawerHeader = styled("div")(({ theme }) => ({
    display: "flex",
    alignItems: "center",
    justifyContent: "flex-end",
    padding: theme.spacing(0, 1),
    // necessary for content to be below app bar
    ...theme.mixins.toolbar,
  }));

  const AppBar = styled(MuiAppBar, {
    shouldForwardProp: (prop) => prop !== "open",
  })(({ theme, open }) => ({
    zIndex: theme.zIndex.drawer + 1,
    transition: theme.transitions.create(["width", "margin"], {
      easing: theme.transitions.easing.sharp,
      duration: theme.transitions.duration.leavingScreen,
    }),
    ...(open && {
      marginLeft: drawerWidth,
      width: `calc(100% - ${drawerWidth}px)`,
      transition: theme.transitions.create(["width", "margin"], {
        easing: theme.transitions.easing.sharp,
        duration: theme.transitions.duration.enteringScreen,
      }),
    }),
  }));

  const Drawer = styled(MuiDrawer, {
    shouldForwardProp: (prop) => prop !== "open",
  })(({ theme, open }) => ({
    width: drawerWidth,
    flexShrink: 0,
    whiteSpace: "nowrap",
    boxSizing: "border-box",
    ...(open && {
      ...openedMixin(theme),
      "& .MuiDrawer-paper": openedMixin(theme),
    }),
    ...(!open && {
      ...closedMixin(theme),
      "& .MuiDrawer-paper": closedMixin(theme),
    }),
  }));

  const theme = useTheme();
  const [open, setOpen] = React.useState(false);

  const handleDrawerOpen = () => {
    setOpen(true);
  };

  const handleDrawerClose = () => {
    setOpen(false);
  };

  //An array of icons in the menu
  const iconList = [
    <DescriptionRoundedIcon />,
    <ChecklistRtlRoundedIcon />,
    <CreditScoreRoundedIcon />,
    <InboxIcon />,
    <TextsmsRoundedIcon />,
  ];

  return (
    <>
      <Box sx={{ display: "flex" }}>
        <CssBaseline />
        <AppBar position="fixed" open={open}>
          <Toolbar>
            <IconButton
              color="inherit"
              aria-label="open drawer"
              onClick={handleDrawerOpen}
              edge="start"
              sx={{
                marginRight: 5,
                ...(open && { display: "none" }),
              }}
            >
              <MenuIcon />
            </IconButton>
            <Typography variant="h6" noWrap component="div">
              בוקר טוב (שם משתמש)
            </Typography>
          </Toolbar>
        </AppBar>
        <Drawer variant="permanent" open={open}>
          <DrawerHeader>
            <IconButton onClick={handleDrawerClose}>
              {theme.direction === "rtl" ? (
                <ChevronRightIcon />
              ) : (
                <ChevronLeftIcon />
              )}
            </IconButton>
          </DrawerHeader>
          <Divider />
          <List>
            {["חוזה עבודה", "מצב עבודה", "תשלום", "הורדה", "צ'אט"].map(
              (text, index) => (
                <ListItem key={text} disablePadding sx={{ display: "block" }}>
                  <ListItemButton
                    sx={{
                      minHeight: 48,
                      justifyContent: open ? "initial" : "center",
                      px: 2.5,
                    }}
                  >
                    <Tooltip title={text}>
                      <ListItemIcon
                        sx={{
                          minWidth: 0,
                          mr: open ? 3 : "auto",
                          justifyContent: "center",
                        }}
                      >
                        {iconList[index]}
                      </ListItemIcon>
                    </Tooltip>
                    <ListItemText
                      primary={text}
                      sx={{ opacity: open ? 1 : 0 }}
                    />
                  </ListItemButton>
                </ListItem>
              )
            )}
          </List>
          <Divider />
        </Drawer>
        <Box component="main" sx={{ flexGrow: 1, p: 3 }}>
          <DrawerHeader />
        </Box>
      </Box>
      <Card
        onClick={() => {
          navigate(`/Contract/`);
        }}
        sx={{ maxWidth: 345 }}
      >
        <CardActionArea>
          {/* <CardMedia
            component="img"
            height="140"
            image="/static/images/cards/contemplative-reptile.jpg"
            // alt="green iguana"
          /> */}
          <CardContent>
            <Typography gutterBottom variant="h5" component="div">
              חוזה עבודה
            </Typography>
            <Typography variant="body2" color="text.secondary">
              אימות חוזה - חתום על הצעת העבודה הטובה ביותר, תוך הבטחת הסכם מועיל
              הדדי שקובע את המסגרת לפרויקט שלך.
            </Typography>
          </CardContent>
        </CardActionArea>
      </Card>
      <Card
        onClick={() => {
          navigate(`/Job_Status/`);
        }}
        sx={{ maxWidth: 345 }}
      >
        <CardActionArea>
          {/* <CardMedia
            component="img"
            height="140"
            image="/static/images/cards/contemplative-reptile.jpg"
            // alt="green iguana"
          /> */}
          <CardContent>
            <Typography gutterBottom variant="h5" component="div">
              מצב עבודה
            </Typography>
            <Typography variant="body2" color="text.secondary">
              עקוב אחר התקדמות - הישאר מעודכן לגבי התקדמות הפרויקט שלך, עקוב אחר
              המצב הנוכחי שלו וראה את התפתחות החזון שלך.
            </Typography>
          </CardContent>
        </CardActionArea>
      </Card>
      <Card
        onClick={() => {
          navigate(`/Payment/`);
        }}
        sx={{ maxWidth: 345 }}
      >
        <CardActionArea>
          {/* <CardMedia
            component="img"
            height="140"
            image="/static/images/cards/contemplative-reptile.jpg"
            // alt="green iguana"
          /> */}
          <CardContent>
            <Typography gutterBottom variant="h5" component="div">
              תשלום
            </Typography>
            <Typography variant="body2" color="text.secondary">
              בצע תשלום - לאחר סיום העבודה, בצע תשלום מאובטח וללא טרחה, מתוך
              הכרה במומחיות ובמאמץ שהשקיע הגרפיקאי.
            </Typography>
          </CardContent>
        </CardActionArea>
      </Card>
      <Card
        onClick={() => {
          navigate(`/Download/`);
        }}
        sx={{ maxWidth: 345 }}
      >
        <CardActionArea>
          {/* <CardMedia
            component="img"
            height="140"
            image="/static/images/cards/contemplative-reptile.jpg"
            // alt="green iguana"
          /> */}
          <CardContent>
            <Typography gutterBottom variant="h5" component="div">
              הורדה
            </Typography>
            <Typography variant="body2" color="text.secondary">
              חבקו את המוצר המוגמר - התענגו על התוצר הסופי, יצירה מלוטשת ושובת
              לב שמביאה את החזון שלכם לחיים, ומשאירה אתכם עם תחושת סיפוק והישג.
            </Typography>
          </CardContent>
        </CardActionArea>
      </Card>
      {/* Opening a chat */}
      {/* <div> */}
        <Button onClick={handleClick}>Open simple snackbar</Button>
        <Snackbar
          open={openChat}
          // autoHideDuration={6000}
          // onClose={handleClose}
          message={<Chat></Chat>}
          action={action}
        ></Snackbar>
      {/* </div> */}
    </>
  );
}

export default Customer;
